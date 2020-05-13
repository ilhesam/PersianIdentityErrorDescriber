using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace PersianIdentityErrorDescriber
{
    public class PersianIdentityErrorDescriber : IdentityErrorDescriber
    {
        #region User Errors

        public override IdentityError UserNotInRole(string role)
            => new IdentityError()
            {
                Code = nameof(UserNotInRole),
                Description = $"کاربر در مقام '{role}' نیست"
            };

        public override IdentityError UserAlreadyInRole(string role)
            => new IdentityError()
            {
                Code = nameof(UserAlreadyInRole),
                Description = $"کاربر در مقام '{role}' است"
            };

        #endregion

        #region UserName Errors

        public override IdentityError DuplicateUserName(string userName)
            => new IdentityError()
            {
                Code = nameof(DuplicateUserName),
                Description = $"نام کاربری {userName} قبلا توسط شخص دیگری انتخاب شده است"
            };

        public override IdentityError InvalidUserName(string userName)
            => new IdentityError()
            {
                Code = nameof(InvalidUserName),
                Description = $"نام کاربری '{userName}' معتبر نیست زیرا نام کاربری فقط میتواند دارای حروف یا عدد باشد"
            };

        #endregion

        #region RoleName Errors

        public override IdentityError DuplicateRoleName(string role)
            => new IdentityError()
            {
                Code = nameof(DuplicateRoleName),
                Description = $"مقام '{role}' قبلا ثبت شده است"
            };

        public override IdentityError InvalidRoleName(string role)
            => new IdentityError()
            {
                Code = nameof(InvalidRoleName),
                Description = $"نام '{role}' ، معتبر نیست"
            };

        #endregion

        #region Email Errors

        public override IdentityError DuplicateEmail(string email)
            => new IdentityError()
            {
                Code = nameof(DuplicateEmail),
                Description = $"ایمیل '{email}' قبلا توسط شخص دیگری انتخاب شده است"
            };

        public override IdentityError InvalidEmail(string email)
            => new IdentityError()
            {
                Code = nameof(InvalidEmail),
                Description = $"ایمیل '{email}' ، معتبر نیست"
            };

        #endregion

        #region Password Errors

        public override IdentityError PasswordRequiresDigit()
            => new IdentityError()
            {
                Code = nameof(PasswordRequiresDigit),
                Description = $"رمز عبور باید حداقل دارای 1 عدد باشد"
            };

        public override IdentityError PasswordRequiresLower()
            => new IdentityError()
            {
                Code = nameof(PasswordRequiresLower),
                Description = $"رمز عبور باید حداقل دارای 1 کاراکتر انگلیسی کوچک باشد ('a'-'z')"
            };

        public override IdentityError PasswordRequiresUpper()
            => new IdentityError()
            {
                Code = nameof(PasswordRequiresUpper),
                Description = $"رمز عبور باید حداقل دارای 1 کاراکتر انگلیسی بزرگ باشد ('A'-'Z')"
            };

        public override IdentityError PasswordRequiresNonAlphanumeric()
            => new IdentityError()
            {
                Code = nameof(PasswordRequiresNonAlphanumeric),
                Description = $"رمز عبور باید حداقل دارای 1 کاراکتر ویژه باشد '@#%^&'"
            };

        public override IdentityError PasswordRequiresUniqueChars(int uniqueChars)
            => new IdentityError()
            {
                Code = nameof(PasswordRequiresUniqueChars),
                Description = $"رمز عبور باید حداقل دارای {uniqueChars} کاراکتر منحصر به فرد باشد"
            };

        public override IdentityError PasswordTooShort(int length)
            => new IdentityError()
            {
                Code = nameof(PasswordTooShort),
                Description = $"رمز عبور نباید کمتر از {length} کاراکتر باشد"
            };

        #endregion

        public override IdentityError DefaultError()
            => new IdentityError()
            {
                Code = nameof(DefaultError),
                Description = $"خطایی پیش بینی نشده رخ داد"
            };
    }
}
