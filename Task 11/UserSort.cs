using System;
using System.Collections.Generic;
using System.Text;

namespace Task_11
{
    internal class UserSort
    {
        public List<string> Strings { get; set; }
        public UserSort(List<string> strings) { Strings = strings; }
        public List<string> DescendingSort() { return Strings.OrderByDescending(u => u).ToList(); }
        public List<string> Sort() { return Strings.OrderBy(u => u).ToList(); }
    }
}
