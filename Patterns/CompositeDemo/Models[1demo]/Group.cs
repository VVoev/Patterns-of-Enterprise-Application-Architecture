using CompositeDemo.Models_1demo_;
using System.Collections.Generic;

namespace CompositeDemo
{
    public class Group : IParty
    {
        public List<IParty> Members { get; set; }

        public string Name { get; set; }

        public int Gold
        {
            get
            {
                int totalGold = 0;
                foreach (var member in this.Members)
                {
                    totalGold += member.Gold;
                }
                return totalGold;
            }
            set
            {
                var eachSplit = value / Members.Count;
                var leftOver = value % Members.Count;
                foreach (var member in Members)
                {
                    member.Gold += eachSplit + leftOver;
                    leftOver = 0;
                }
            }



        }

        public Group()
        {
            this.Members = new List<IParty>();
        }

        public void Stats()
        {
            foreach (var member in Members)
            {
                member.Stats();
            }
        }
    }

}
