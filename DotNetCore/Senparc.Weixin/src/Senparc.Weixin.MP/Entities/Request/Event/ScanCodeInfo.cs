﻿/*----------------------------------------------------------------
    Copyright (C) 2015 LSW
    
    文件名：ScanCodeInfo.cs
    文件功能描述：扫码事件中的ScanCodeInfo
    
    
    创建标识：LSW - 20150211
    
    修改标识：LSW - 20150303
    修改描述：整理接口
----------------------------------------------------------------*/

namespace Senparc.Weixin.MP.Entities
{
    /// <summary>
    /// 扫码事件中的ScanCodeInfo
    /// </summary>
    public class ScanCodeInfo
    {
        public string ScanType { get; set; }
        public string ScanResult { get; set; }
    }
}
