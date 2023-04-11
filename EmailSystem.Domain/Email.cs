using System;

namespace EmailSystem.Domain
{
    public class Email
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime SentOn { get; set; }

        public Guid RecipientId { get; set; }

        public Employee RecipientEmployee { get; set; }

        public Guid SenderId { get; set; }

        public Employee SenderEmployee { get; set; }

        public string Content { get; set; }
    }
}
