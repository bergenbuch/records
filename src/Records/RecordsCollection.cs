using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Records
{
    public class RecordsCollection<T> : ReadOnlyCollection<T>
    {
        public RecordsCollection(params T[] values) : base(values == null
            ? new List<T>()
            : new List<T>(values))
        {
        }

        public RecordsCollection(IList<T> list) : base(list)
        {
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            return obj is RecordsCollection<T> collection &&
                   collection.Items.SequenceEqual(Items);
        }


        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            foreach (T item in Items)
            {
                hashCode.Add(item);
            }

            return hashCode.ToHashCode();
        }
    }
}