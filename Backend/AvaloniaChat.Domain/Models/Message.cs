﻿using System;
using System.Collections.Generic;

namespace AvaloniaChat.Domain.Models
{
    public partial class Message
    {
        public Guid MessageId { get; set; }
        public int UsergroupId { get; set; }
        public string MessageText { get; set; } = null!;
        public int UserId { get; set; }

        public DateTime SendDate { get; set; }
        public virtual UserGroup Usergroup { get; set; } = null!;
       // public virtual User User { get; set; } = null!;
    }
}
