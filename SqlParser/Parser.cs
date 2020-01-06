using System;

namespace SqlParser
{
    public class Parser
    {
        public bool IsSelect(string sql)
        {
            return sql != null && sql.StartsWith("select ", StringComparison.InvariantCultureIgnoreCase);
        }

        public bool IsInsert(string sql)
        {
            return sql != null && sql.StartsWith("insert ", StringComparison.InvariantCultureIgnoreCase);
        }

        public bool IsDelete(string sql)
        {
            return sql != null && sql.StartsWith("delete ", StringComparison.InvariantCultureIgnoreCase);
        }

        public bool IsUpdate(string sql)
        {
            return sql != null && sql.StartsWith("update ", StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
