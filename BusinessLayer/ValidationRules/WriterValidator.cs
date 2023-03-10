using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class WriterValidator : AbstractValidator<Writer>
	{
		public WriterValidator()
		{
			RuleFor(x => x.WriterMail).NotEmpty().WithMessage("E-mail Boş Olamaz!");
			RuleFor(x => x.WriterMail).EmailAddress().WithMessage("Lütfen doğru bir e mail giriniz.");
			RuleFor(x => x.WriterName).NotEmpty().WithMessage("Lütfen Ad-Soyad Alanını Boş Bırakmayınız.");
			RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen Ad-Soyad Alanını 50 Karakterden Fazla Girmeyiniz.");
			RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter giriniz.");
			RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre Boş Geçilemez")
				.MinimumLength(8).WithMessage("Şifre 8 karakterden küçük olamaz.")
				.MaximumLength(16).WithMessage("Şifre 16 karakterden büyük olamaz.")
				.Matches(@"[A-Z]+").WithMessage("Şifrede en az bir büyük harf olmalıdır.")
				.Matches(@"[a-z]+").WithMessage("Şifrede en az bir küçük harf olmalıdır.")
				.Matches(@"[0-9]+").WithMessage("Şifrede en az bir rakam olmalıdır");
			RuleFor(x => x.ConfirmPassword).Equal(x => x.WriterPassword).WithMessage("Şifreler Uyuşmuyor!");
		}
	}
}
