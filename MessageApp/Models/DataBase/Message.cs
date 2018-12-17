using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MessageApp.Models.DataBase
{
    public class Message
    {
        public Guid Id { get; set; }

        public string Content { get; set; }

        public DateTime CreatedDate { get; set; }

        [ForeignKey("Channel")]
        public Guid? Channel_Id { get; set; }

        public virtual Channel Channel { get; set; }
    }

    public class Channel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Message> Messages { get; set; }
    }
}