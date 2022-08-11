using RV4US.API.RV.PROC.Repository.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RV4US.API.RV.PROC.Repository
{
    public class RVModelsComparer : IEqualityComparer<Models.RVModels>
    {
        public bool Equals(RVModels x, RVModels y)
        {
            //Check whether the compared objects reference the same data.
            if (object.ReferenceEquals(x, y)) return true;

            //Check whether any of the compared objects is null.
            if (object.ReferenceEquals(x, null) || object.ReferenceEquals(y, null))
                return false;

            //Check whether the products' properties are equal.
            return x.Id == y.Id && x.ShortName == y.ShortName;
        }

        public int GetHashCode([DisallowNull] RVModels obj)
        {
            //Check whether the object is null
            if (Object.ReferenceEquals(obj, null)) return 0;

            //Get hash code for the ShortName field if it is not null.
            int hashRVShortName = obj.ShortName == null ? 0 : obj.ShortName.GetHashCode();

            //Get hash code for the Id field.
            int hashRVId = obj.Id.GetHashCode();

            //Calculate the hash code for the RVModels.
            return hashRVShortName ^ hashRVId;
        }
    }
}
