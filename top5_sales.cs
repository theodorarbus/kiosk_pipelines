new BsonArray
{
    new BsonDocument("$group", 
    new BsonDocument
        {
            { "_id", "$ProductName" }, 
            { "TotalSold", 
    new BsonDocument("$sum", "$Quantity") }
        }),
    new BsonDocument("$sort", 
    new BsonDocument("TotalSold", -1)),
    new BsonDocument("$limit", 5)
}