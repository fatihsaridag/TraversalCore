﻿namespace TraversalCore.Mvc.CQRS.Results.DestinationResults
{
    public class GetAllDestinationQueryResult
    {
        public int Id { get; set; }
        public string City { get; set; }
        public double Price { get; set; }
        public int Capacity{ get; set; }
        public string DayNight{ get; set; }
    }
}
