﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebRandomizer.Models {
    public enum ClientState {
        Disconnected,
        Registering,
        Registered,
        Identifying,
        Patching,
        Ready,
        Playing,
        Completed
    }

    public class Client {
        public int Id { get; set; }
        public string Guid { get; set; }
        public string Name { get; set; }
        public string Device { get; set; }
        public ClientState State { get; set; }
        public string ConnectionId { get; set; }
        public int SessionId { get; set; }
    }
}
