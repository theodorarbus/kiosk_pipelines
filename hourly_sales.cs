new BsonArray
{
    new BsonDocument("$group", 
    new BsonDocument
        {
            { "_id", 
    new BsonDocument("$hour", "$SalesTimestamp") }, 
            { "TotalSold", 
    new BsonDocument("$sum", "$Quantity") }
        }),
    new BsonDocument("$sort", 
    new BsonDocument("_id", 1))
}