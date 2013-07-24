using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Podio.API.Model;

namespace Podio.API.Utils.ItemFilters
{
    /// <summary>
    /// Contains helper functions that generate filter objects for standard item fields.
    /// </summary>
    public static class StandardFilters
    {
        public static KeyValuePair<string, IPodioFilter> CreatedByFilter(AuthObjectType type, int id)
        {
            var author = new AuthObjectFilter(){AuthorType = type, AuthorId = id};
            return new KeyValuePair<string, IPodioFilter>("created_by", author);
        }

        public static KeyValuePair<string, IPodioFilter> CreatedVia(IList<int> ids)
        {
            CollectionFilter<int> filter = new CollectionFilter<int>(ids);
            return new KeyValuePair<string, IPodioFilter>("created_via", filter);
        }

        public static KeyValuePair<string, IPodioFilter> LastEditByFilter(AuthObjectType type, int id)
        {
            var author = new AuthObjectFilter() { AuthorType = type, AuthorId = id };
            return new KeyValuePair<string, IPodioFilter>("last_edit_by", author);
        }

        public static KeyValuePair<string, IPodioFilter> LastEditViaFilter(IList<int> ids)
        {
            CollectionFilter<int> filter = new CollectionFilter<int>(ids);
            return new KeyValuePair<string, IPodioFilter>("last_edit_via", filter);
        }

        public static KeyValuePair<string, IPodioFilter> CreatedOnFilter(DateFilter filter)
        {
            return new KeyValuePair<string, IPodioFilter>("created_on", filter);
        }

        public static KeyValuePair<string, IPodioFilter> ExternalIdFilter(string exernalId)
        {
            ValueFilter<string> filter = new ValueFilter<string>(exernalId);
            return new KeyValuePair<string, IPodioFilter>("external_id", filter);
        }

        public static KeyValuePair<string, IPodioFilter> TitleFilter(string title)
        {
            ValueFilter<string> filter = new ValueFilter<string>(title);
            return new KeyValuePair<string, IPodioFilter>("title", filter);
        }

        public static KeyValuePair<string, IPodioFilter> TagsFilter(IList<string> tags)
        {
            var filter = new CollectionFilter<string>(tags);
            return new KeyValuePair<string, IPodioFilter>("tags", filter);
        }

        public static KeyValuePair<string, IPodioFilter> LikedFilter()
        {
            ValueFilter<int> filter = new ValueFilter<int>(1);
            return new KeyValuePair<string, IPodioFilter>("like", filter);
        }

        public static KeyValuePair<string, IPodioFilter> ApprovedRatingFilter(ApproveRating rating)
        {
            var filter = new ValueFilter<int>((int)rating);
            return new KeyValuePair<string, IPodioFilter>("approved", filter);
        }

        public static KeyValuePair<string, IPodioFilter> RsvpRatingFilter(RsvpRating rating)
        {
            var filter = new ValueFilter<int>((int)rating);
            return new KeyValuePair<string, IPodioFilter>("rsvp", filter);
        }

        public static KeyValuePair<string, IPodioFilter> YesNoRatingFilter(YesNoRating rating)
        {
            var filter = new ValueFilter<int>((int)rating);
            return new KeyValuePair<string, IPodioFilter>("yesno", filter);
        }

        public static KeyValuePair<string, IPodioFilter> ThumbsRatingFilter(ThumbsRating rating)
        {
            var filter = new ValueFilter<int>((int)rating);
            return new KeyValuePair<string, IPodioFilter>("thumbs", filter);
        }

        public static KeyValuePair<string, IPodioFilter> StarRatingFilter(StarRating rating)
        {
            var filter = new ValueFilter<int>((int)rating);
            return new KeyValuePair<string, IPodioFilter>("fivestar", filter);
        }
    }
}
