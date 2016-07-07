﻿/*----------------------------------------------------------------
    Copyright (C) 2015 LSW
    
    文件名：SingleButton.cs
    文件功能描述：所有单击按钮的基类
    
    
    创建标识：LSW - 20150211
    
    修改标识：LSW - 20150303
    修改描述：整理接口
----------------------------------------------------------------*/

namespace Senparc.Weixin.MP.Entities.Menu
{
    /// <summary>
    /// 所有单击按钮的基类（view，click等）
    /// </summary>
    public abstract class SingleButton : BaseButton, IBaseButton
    {
        /// <summary>
        /// 按钮类型（click或view）
        /// </summary>
        public string type { get; set; }

        public SingleButton(string theType)
        {
            type = theType;
        }
    }
}
