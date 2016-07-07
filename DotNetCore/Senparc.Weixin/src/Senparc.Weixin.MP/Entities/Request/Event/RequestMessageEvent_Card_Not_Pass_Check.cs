﻿/*----------------------------------------------------------------
    Copyright (C) 2015 LSW
    
    文件名：RequestMessageEvent_Card_Not_Pass_Check.cs
    文件功能描述：事件之卡券未通过审核
    
    
    创建标识：LSW - 20150211
    
    修改标识：LSW - 20150303
    修改描述：整理接口
----------------------------------------------------------------*/

namespace Senparc.Weixin.MP.Entities
{
    public class RequestMessageEvent_Card_Not_Pass_Check : RequestMessageEventBase, IRequestMessageEventBase
    {
        /// <summary>
        /// 卡券未通过审核
        /// </summary>
        public override Event Event
        {
            get { return Event.card_not_pass_check; }
        }

        /// <summary>
        /// 卡券ID
        /// </summary>
        public string CardId { get; set; }
    }
}
