﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DooChatBot.Models
{
    [Serializable]
    public class ConversationHistory
    {
        public string commonBeforeQustion;
        public int facebookPageCount;

        public string luisEntities;
        
        public int dlgOrderNo;
        public string dlgApiDefine;
        public int apiId;
    }
}