using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace QuizBowlSchema.Extensions
{
    public static class EnumExtensions
    {
        private static T GetAttributeOrDefault<T>(this Enum value) where T : Attribute
        {
            var enumType = value.GetType();
            var enumMember = enumType.GetMember(value.ToString()).FirstOrDefault();

            T result = null;

            if (enumMember != null)
            {
                result = enumMember.GetCustomAttributes(typeof(T), false)
                    .ToList()
                    .FirstOrDefault() as T;
            }
            return result;
        }

        public static string ToDescription(this Enum value)
        {
            var display = GetAttributeOrDefault<DisplayAttribute>(value);

            return display != null ? display.Description : value.ToString();
        }
    }
}