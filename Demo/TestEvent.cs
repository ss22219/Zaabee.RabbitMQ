﻿using System;
using Zaabee.RabbitMQ.Abstractions;

namespace Demo
{
    [MessageVersion("3.14")]
    public class TestEvent
    {
        public Guid Id { get; set; }
        public DateTimeOffset Timestamp { get; set; }
    }
}