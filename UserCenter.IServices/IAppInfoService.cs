﻿/// ***********************************************************************
///
/// =================================
/// CLR版本	：4.0.30319.42000
/// 命名空间	：UserCenter.IServices
/// 文件名称	：IAppInfoService.cs
/// =================================
/// 创 建 者	：wyt
/// 创建日期	：2018/11/8 10:40:33 
/// 邮箱		：786744873@qq.com
/// 个人主站	：https://www.cnblogs.com/wyt007/
///
/// 功能描述	：
/// 使用说明	：
/// =================================
/// 修改者	：
/// 修改日期	：
/// 修改内容	：
/// =================================
///
/// ***********************************************************************


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCenter.DTO;

namespace UserCenter.IServices
{
    /// <summary>
    /// 
    /// <see cref="IAppInfoService" langword="" />
    /// </summary>
    public interface IAppInfoService:IServiceTag
    {
        Task<long> AddNewAsync(string name, string appKey);

        Task<AppInfoDTO> GetByAppKeyAsync(string appKey);

    }
}
