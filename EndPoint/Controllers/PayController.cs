using Amazon.Runtime.Internal.Util;
using Dto.Payment;
using Microsoft.AspNetCore.Mvc;
using Project.Application.Payment;
using Project.EndPoint.Utilities;
using System.Data;
using System.Runtime.CompilerServices;
using ZarinPal.Class;






namespace Project.EndPoint.Controllers
{
    public class PayController : Controller
    {
        private readonly Payment _payment;
        private readonly Authority _authority;
        private readonly Transactions _transactions;
        private readonly IConfiguration configuration;
        private readonly IPaymentServices __payment;
        private string merchantId;

        public PayController(IConfiguration configuration, IPaymentServices payment)
        {
            this.configuration = configuration;
            __payment = payment;
            merchantId = configuration["ZarinPalMerchantId"];

            var expose = new Expose();
            _payment = expose.CreatePayment();
            _authority = expose.CreateAuthority();
            _transactions = expose.CreateTransactions();
        }
        public async Task<IActionResult>  Index(Guid PaymentId)
        {
            var payment = __payment.GetPayment(PaymentId);
            if(payment == null)
            {
                return NotFound();
            }
            string UserId = ClaimUtility.GetUserId(User);
            if(UserId !=payment.UserId)
            {
                return BadRequest();
            }
            string callBackUrl = Url.Action(nameof(Verify),"pay", new {paymentId = payment.Id},protocol:Request.Scheme);
            var result = await _payment.Request(new DtoRequest()
            {
                Mobile = payment.PhoneNumber,
                CallbackUrl = callBackUrl,
                Description = $"پرداخت برای فاکتور شماره: {payment.Id}",
                Email = payment.Email,
                Amount = payment.Amount,
                MerchantId = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX"
            }, ZarinPal.Class.Payment.Mode.sandbox);
            return Redirect($"https://sandbox.zarinpal.com/pg/StartPay/{result.Authority}");

        }

        public async Task<IActionResult> Verify(Guid paymentId, string Authority, string Status)
        {

            if ((Status !="" && Status.ToString().ToLower()=="ok") && Authority != "") 
            {
                var payment = __payment.GetPayment(paymentId);
                if(payment == null)
                {
                    return NotFound();
                }
                var verification = await _payment.Verification(new DtoVerification
                {
                    Amount = payment.Amount,
                    MerchantId = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX",
                    Authority = Authority
                }, Payment.Mode.sandbox);

                if (verification.Status == 100)
                {
                    bool verifyResult = __payment.VerifyPayment(paymentId, Authority, verification.RefId);
                    if ((verifyResult))
                    {
                        return Redirect("/customers/orders");
                    }
                    else
                    {
                        TempData["message"] = "پرداخت انجام شد ولی ثبت نشد.";
                        return RedirectToAction("checkout", "basket");
                    }
                }
                else
                {
                    TempData["message"] = "پرداخت شما نا موفق بوده است. در صورت بروز مشکل با مدیریت تماس بگیرید.";
                    return RedirectToAction("checkout", "basket");
                }
            }

            return View();
        }
    }
}
