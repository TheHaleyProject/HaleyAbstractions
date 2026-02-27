namespace Haley.Enums {
    public enum ResultFilter {
        None = 0, //All dictionary as List.. List of Dictionaries . One dictionary represents one Row. and each KVP is a column name/value pair.
        FlattenedValuesList, //Flattened list of all values (ignoring the column name.. just the values.. Use with caution.
        NestedValuesList, //Nested list of all values.
        FirstDictionary, //First Row alone is returned.
        FirstDictionaryValue, //For Scalar operations. First dictionaries, first value is alone returned.
        FirstColumnValuesList
    }
}
