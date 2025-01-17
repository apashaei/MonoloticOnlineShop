﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Visitors.visitor
{
    public class Visitor
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string IP { get; set; }
        public string CurrentLink { get; set; }
        public string ReferrerLink { get; set; }
        public string Method { get; set; }
        public string Protocol { get; set; }
        public string PhysicalPath { get; set; }

        [BsonDateTimeOptions(Kind =DateTimeKind.Local)]
        public DateTime Time { get; set; }
        public string VisitorId { get; set; }

        public VisitorVersion Browser {  get; set; }
        public VisitorVersion OperationSystem { get; set; }
        public Device Device { get; set; }
    }
}
