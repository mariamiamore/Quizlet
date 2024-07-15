using System;
namespace Quizlet
{
internal class Account
{
	public static List<string> Username = new List<string>();
	
	public static void CreateUsernames()
	{
		Username.Add("maria");
		Username.Add("Mariamiamore");
		Username.Add("Mariaa04");
		Username.Add("Ma_ria04");
	}
	
	public static bool Login(string username)
	{
		CreateUsernames();
		bool result = false;
		
		foreach (var user in Username)
		{
			if (user == username)
			{
				result = true;
			}
		}
		return result;
	}
	
}
} 