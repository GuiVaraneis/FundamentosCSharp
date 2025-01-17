using Intro_Enum.Entities.Enums;
using System.Threading.Channels;

namespace Intro_Enum.Entities {
     class Order {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString() {
            return "id: " + Id+ ", horário: " + Moment + ", Status: " + Status;
        }

        
    }
}
