namespace API.Entities;

public class AppUser
{
    /// <summary>
    /// 取名Id=>Entity Framework會知道要把該欄位當作primary key
    /// </summary>
    public int Id{get;set;}

    public string UserName{get;set;}
}
