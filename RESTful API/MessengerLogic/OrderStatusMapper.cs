﻿namespace RESTful_API.MessengerLogic
{
    public class OrderStatus
    {
        public string Value { get; set; }
        public string Label { get; set; }

        public OrderStatus(string value, string label)
        {
            Value = value;
            Label = label;
        }
    }
}
