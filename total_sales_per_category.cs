new BsonArray
{
    new BsonDocument("$group", 
    new BsonDocument
        {
            { "_id", "$Category" }, 
            { "TotalSold", 
    new BsonDocument("$sum", "$Quantity") }, 
            { "TotalRevenue", 
    new BsonDocument("$sum", 
    new BsonDocument("$multiply", 
    new BsonArray
                    {
                        "$Quantity",
                        "$Price"
                    })) }
        })
}