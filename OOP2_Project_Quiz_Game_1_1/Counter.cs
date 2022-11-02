using System;
namespace OOP2_Project_Quiz_Game_1_1
{
    public class Counter
    {
        public int indexNo { get; set; }

        public Counter()
        {

        }

        public int GetKeyIndex(List<KeyValuePair<string, string>> list, string value)
        {
            foreach (var item in list)
            {
                if (item.Key == value)
                {
                    indexNo = list.IndexOf(item);
                    return indexNo;
                }
            }
            throw new ArgumentException("Category not available!");
        }

        public int GetKeyIndex(List<KeyValuePair<string, List<string>>> list, string value)
        {
            foreach (var item in list)
            {
                if (item.Key == value)
                {
                    indexNo = list.IndexOf(item);
                    return indexNo;
                }
            }
            throw new ArgumentException("Category not available!");
        }
    }
}

