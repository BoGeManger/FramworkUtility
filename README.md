# FramworkUtility
## Common background extension method
### .ToStr() Converts to a string
- prototype
```cs
public static string ToStr<T>(this T source)
```
- Return value
If it is empty, return an empty string (not null)
- Sample
```cs
var str = tempValue.ToStr();
```

### .ToInt() Converts to integers
- prototype
```cs
public static int ToInt<T>(this T source)
```
- Return value
If the conversion fails, return 0
- Sample
```cs
var value = "1234".ToInt();
```
### .ToIntNull() Conversion to an empty integer
- prototype
```cs
public static int? ToIntNull<T>(this T source)
```
- Return value
If the value is null, then return to null
- Sample
```cs
var value = "1234".ToIntNull();
```
### .ToBool() Conversion to Boolean
- prototype
```cs
public static bool ToBool<T>(this T source)
```
- Return value
If the conversion fails, return to false
- Sample
```cs
var value = "True".ToBool();
```
### .ToDecimal() Conversion to Decimal
- prototype
```cs
public static decimal ToDecimal<T>(this T source)
```
- Return value
If the conversion fails, return 0
- Sample
```cs
var value = "1234.56".ToDecimal();
```
### .ToDecimalNull() Conversion to empty Decimal
- prototype
```cs
public static decimal? ToDecimalNull<T>(this T source)
```
- Return value
If the value is null, then return to null
- Sample
```cs
var value = "1234.56".ToDecimalNull();
```
### .ToDateNull Conversion to an empty date
- prototype
```cs
public static DateTime? ToDateNull<T>(this T source)
```
- Return value
If the value is null, then return to null
- Sample
```cs
var value = Datatime.Now.ToDateNull();
```
### .ToDateNow Convert to date
- prototype
```cs
public static DateTime ToDateNow<T>(this T source)
```
- Return value
If the value is null, the current time is returned.
- Sample
```cs
var value = Datatime.Now.ToDateNow();
```
### .ToGuid() Convert to Guid
- prototype
```cs
public static Guid ToGuid<T>(this T source)
```
- Return value
If the conversion fails, return to Guid.Empty
- Sample
```cs
var value = "6F9619FF-8B86-D011-B42D-00C04FC964FF".ToGuid();
```
### .ToGuidNull() Conversion to empty Guid
- prototype
```cs
public static Guid? ToGuidNull<T>(this T source)
```
- Return value
If the value is null, then return to null
- Sample
```cs
var value = "6F9619FF-8B86-D011-B42D-00C04FC964FF".ToGuidNull();
```
### .ToEnum() Conversion to enumeration
- prototype
```cs
public static T ToEnum<T>(this object source)
```
- Return value
If the conversion fails, default (T)
- Sample
```cs
public enum UpdateType{
	Add = 1,
	Modify = 2,
	Delete = 3
}
var value = "Add".ToEnum<UpdateType>(); 
```
### .IsEmpty() Determine whether a string is empty
- prototype
```cs
public static bool IsEmpty(this string str)
```
- Return value
Return to false if true is returned for null or null
- Sample
```cs
var str = 'Test'
var isEmpty = str.IsEmpty();
```
### .IsId() Determine if the integer is Id (Id greater than 0)
- prototype
```cs
public static bool IsId(this int source)
```
- Return value
Return to false if the value is greater than zero and returns true
- Sample
```cs
var id = 1;
if (id.IsId()){
   ...
}
```
### .EqualsIgnoreCase() Determine whether strings match, ignore case
- prototype
```cs
public static bool EqualsIgnoreCase(this string str, string compareStr)
```
- Return value
If case matching is ignored, true is returned, otherwise false is returned.
- Sample
```cs
var result = "Abc".EqualsIgnoreCase("ABC");
```
### .IsGuid() Determine whether the string is Guid
- prototype
```cs
public static bool IsGuid(this string str)
```
- Return value
Determine whether the string is Guid
- Sample
```cs
var result = "6F9619FF-8B86-D011-B42D-00C04FC964FF".IsGuid();
```
### .CopyToDataTable() DataRow Conversion to  DataTable
- prototype
```cs
public static DataTable CopyToDataTable(this IEnumerable<DataRow> rows, DataTable table)
```
- Return value
return DataTable
- Sample
```cs
var dt = new DataTable();
// 处理 dl
var rows = dt.AsEnumerable().Where(c=>!c["Name"].IsEmpty()).ToList();
var table = rows.CopyToDataTable();
```
### .ToSafeSqlInt() Conversion to an integer (SQL anti injection)
- prototype
```cs
public static int ToSafeSqlInt<T>(this T source)
```
- Return value
If the conversion fails, return 0
- Sample
```cs
var value = "1234".ToInt();
```
### .ToSafeSqlDecimal() Conversion to Decimal (SQL anti injection)
- prototype
```cs
public static decimal ToSafeSqlDecimal<T>(this T source)
```
- Return value
If the conversion fails, return 0
- Sample
```cs
var value = "1234.56".ToSafeSqlDecimal();
```
### .ToSafeSqlStr() Conversion to string (SQL anti injection)
- prototype
```cs
public static string ToSafeSqlStr<T>(this T source)
```
- Return value
If the value is null or empty, return to string.Empty
- Sample
```cs
var value = "' drop table TestTable;".ToSafeSqlStr();
```
### .ToSafeDateNull() Conversion to date (SQL anti injection)
- prototype
```cs
public static DateTime? ToSafeDateNull<T>(this T source)
```
- Return value
If the conversion fails, return to null
- Sample
```cs
var value = "2017-12-31".ToSafeDateNull();
```
### .GetValue() Dictionary Dictionary gets the value
- prototype
```cs
public static TValue GetValue<TKey, TValue>(this Dictionary<TKey, TValue> source, TKey key)
```
- Return value
If key does not exist, return to default (TValue)
- Sample
```cs
var dict = new Dictionary<string,String>();
//...Handle
var value = dict.GetValue('TestKey');
```
### .ToUpperString() Convert string to uppercase, often used in Guid, uppercase and so on.
- prototype
```cs
public static string ToUpperString(this Guid source)
```
- Return value
如果string.ToUpper()
- Sample
```cs
var str = "Abc".ToUpper(); // ABC
```
### .ToJsonString() DataTabl Conversion to JSON
- prototype
```cs
public static string ToJsonString(this DataTable source)
```
- Return value
Return to the JSON string
- Sample
```cs
DataTable data = null;
var str = data.ToJsonString();
```
### .FormatAmount() Formatted amount
- prototype
```cs
public static decimal FormatAmount<T>(this T amount)
```
- Return value
Return amount
- Sample
```cs
decimal data = 1213.123;
var str = data.FormatAmount();//1213.12
```
