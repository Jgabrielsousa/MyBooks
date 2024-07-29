using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;


namespace MyBook.Data.Configuration.Base
{
    public static class Extension
    {
        public static PropertyBuilder<TProperty> AddDateTime<TProperty>(this PropertyBuilder<TProperty> propertyBuilder)
        {
            var datetime = SqlType.Datetime;
            propertyBuilder
            .HasColumnType(datetime.ColumnType)
            .HasDefaultValueSql(datetime.ValueSql);
            return propertyBuilder;
        }


        public static PropertyBuilder<TProperty> AddString<TProperty>(this PropertyBuilder<TProperty> propertyBuilder, int? length = null)
        {
            propertyBuilder
            .HasMaxLength(length ?? SqlType.Nvarchar.Length)
            .IsUnicode(false);
            return propertyBuilder;
        }

        public static PropertyBuilder<TProperty> AddDefaultValue<TProperty>(this PropertyBuilder<TProperty> propertyBuilder, string defaultValue)
        {

            if (!string.IsNullOrEmpty(defaultValue))
                propertyBuilder.HasDefaultValueSql(defaultValue);

            return propertyBuilder;
        }



        public static PropertyBuilder<TProperty> AddInteger<TProperty>(this PropertyBuilder<TProperty> propertyBuilder)
        {
            propertyBuilder
            .HasColumnType(SqlType.Int.ColumnType)
            .IsUnicode(false);
            return propertyBuilder;
        }
        public static PropertyBuilder<TProperty> AddUniqueidentifier<TProperty>(this PropertyBuilder<TProperty> propertyBuilder)
        {
            propertyBuilder
            .HasColumnType(SqlType.Uniqueidentifier.ColumnType);
            return propertyBuilder;
        }
        public static PropertyBuilder<TProperty> AddBit<TProperty>(this PropertyBuilder<TProperty> propertyBuilder)
        {
            propertyBuilder
            .HasColumnType(SqlType.Bit.ColumnType);
            return propertyBuilder;
        }

    }
}
