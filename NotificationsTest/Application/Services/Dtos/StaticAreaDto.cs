using System.Drawing;

namespace NotificationsTest.Application.Services.Dtos {
    internal class StaticAreaDto  {
        public long Id { get; set; }
        public string Name { get; set; }
        //public StaticAreaType Type { get; set; }
        public Color Color { get; set; }
        //public IList<PointD> Polygon { get; set; }
    }
}
