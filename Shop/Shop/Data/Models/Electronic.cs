namespace Shop.Data.Models
{
    public class Electronic {
        public int id { set; get; }
        public string name { set; get; }
        public string shortDesk { set; get; }
        public string longDesk { set; get; }
        public string img { set; get; }
        public ushort price { set; get; }
        public bool isFavourite { set; get; }
        public bool available { set; get; }
        public int categoryID { set; get; }
        public virtual Category Category { set; get; }

    }
}
