using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Web
{
	public class GuestResponse
	{
		[Required(ErrorMessage = "请输入姓名")]
		[StringLength(maximumLength:20,MinimumLength = 1)]
		[Display(Name="请输入姓名")]
		public string Name { get; set; }
		[Display(Name="邮箱")]
		[Required(ErrorMessage = "请输入邮箱")]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }
		[Required(ErrorMessage = "请输入电话")]
		public string Phone { get; set; }
		[Required(ErrorMessage = "请选择是否参加", AllowEmptyStrings = false)]
		public bool? WillAttend { get; set; }

		public GuestResponse()
		{
			
		}
	}
}
