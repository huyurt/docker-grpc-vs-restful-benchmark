//using ProtoBuf;

namespace Benchmark.Shared.Models
{
    //[ProtoContract]
    public class UserModel
    {
        //[ProtoMember(1)]
        public long Id { get; set; }

        //[ProtoMember(2)]
        //private string referenceKey
        //{
        //    get => ReferenceKey.ToString();
        //    set => ReferenceKey = Guid.Parse(value);
        //}
        public Guid ReferenceKey { get; set; }

        //[ProtoMember(3)]
        //private double balance
        //{
        //    get => decimal.ToDouble(Balance);
        //    set => Balance = Convert.ToDecimal(value);
        //}
        public decimal Balance { get; set; }

        //[ProtoMember(4)]
        public string Name { get; set; }

        //[ProtoMember(5)]
        public string? MiddleName { get; set; }

        //[ProtoMember(6)]
        public string Surname { get; set; }

        //[ProtoMember(7)]
        //private string birthDate
        //{
        //    get => BirthDate.HasValue ? BirthDate.Value.ToString("s") : null;
        //    set => BirthDate = value != null ? DateTime.Parse(value) : null;
        //}
        public DateTime? BirthDate { get; set; }

        //[ProtoMember(8)]
        public string Email { get; set; }

        //[ProtoMember(9)]
        public long? IdentityNo { get; set; }

        //[ProtoMember(10)]
        public bool IsActive { get; set; }

        //[ProtoMember(11)]
        //private string registered
        //{
        //    get => Registered.ToString("s");
        //    set => Registered = DateTime.Parse(value);
        //}
        public DateTime Registered { get; set; }

        //[ProtoMember(12)]
        public string[] Tags { get; set; }

        //[ProtoMember(13)]
        public Contact[] Contacts { get; set; }

        //[ProtoMember(14)]
        public Friend[] Friends { get; set; }

        //[ProtoMember(15)]
        public long[] FriendIds { get; set; }
    }

    //[ProtoContract]
    public class Contact
    {
        //[ProtoMember(1)]
        public long Phone { get; set; }

        //[ProtoMember(2)]
        public string Address { get; set; }
    }

    //[ProtoContract]
    public class Friend
    {
        //[ProtoMember(1)]
        public long Id { get; set; }

        //[ProtoMember(2)]
        public string Name { get; set; }

        //[ProtoMember(3)]
        public string Surname { get; set; }
    }
}
