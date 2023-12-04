using System;
using System.Collections.Generic;

namespace WebApplication13.Models;

public partial class TbUser
{
    public string SuNo { get; set; } = null!;

    public string UserNo { get; set; } = null!;

    public string? UserName { get; set; }

    public string? UserPwd { get; set; }

    public string? UserTel { get; set; }

    public bool Admin { get; set; }

    public string? GroupType { get; set; }

    public string? WebAlertStatus { get; set; }

    public string? Dept { get; set; }

    public int? Level { get; set; }

    public string? Email { get; set; }

    public int? Alertsend { get; set; }

    /// <summary>
    /// 後台登入設定
    /// </summary>
    public int? WebChk { get; set; }

    /// <summary>
    /// app登入設定
    /// </summary>
    public int? AppChk { get; set; }

    /// <summary>
    /// 登入錯誤次數
    /// </summary>
    public int? Loginerrorcount { get; set; }

    /// <summary>
    /// 預設密碼未登入過0，已登入過1
    /// </summary>
    public int? Firstlogin { get; set; }

    /// <summary>
    /// 鎖定可登入時間(要大於此時間才能再重試)
    /// </summary>
    public DateTime? Locktime { get; set; }

    /// <summary>
    /// 密碼到期時間
    /// </summary>
    public DateTime? Passwordexpire { get; set; }

    /// <summary>
    /// 最後一次登入時間
    /// </summary>
    public DateTime? Finallogintime { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    public DateTime? Createtime { get; set; }
}
