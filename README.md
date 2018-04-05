# FramworkUtility
## 后台常用扩展方法
### .ToStr() 转换为字符串
- 原型
```cs
public static string ToStr<T>(this T source)
```
- 返回值
如果为空，返回空字符串(不是null)
- 示例
```cs
var str = tempValue.ToStr();
```

### .ToInt() 转换为整数
- 原型
```cs
public static int ToInt<T>(this T source)
```
- 返回值
如果转换失败，返回0
- 示例
```cs
var value = "1234".ToInt();
```
### .ToIntNull() 转换为可空整数
- 原型
```cs
public static int? ToIntNull<T>(this T source)
```
- 返回值
如果值为null，则返回null
- 示例
```cs
var value = "1234".ToIntNull();
```
### .ToBool() 转换为布尔型
- 原型
```cs
public static bool ToBool<T>(this T source)
```
- 返回值
如果转换失败，返回false
- 示例
```cs
var value = "True".ToBool();
```
### .ToDecimal() 转换为Decimal
- 原型
```cs
public static decimal ToDecimal<T>(this T source)
```
- 返回值
如果转换失败，返回0
- 示例
```cs
var value = "1234.56".ToDecimal();
```
### .ToDecimalNull() 转换为可空Decimal
- 原型
```cs
public static decimal? ToDecimalNull<T>(this T source)
```
- 返回值
如果值为null，则返回null
- 示例
```cs
var value = "1234.56".ToDecimalNull();
```
### .ToDateNull 转换为可空日期
- 原型
```cs
public static DateTime? ToDateNull<T>(this T source)
```
- 返回值
如果值为null，则返回null
- 示例
```cs
var value = Datatime.Now.ToDateNull();
```
### .ToDateNow 转换为日期
- 原型
```cs
public static DateTime ToDateNow<T>(this T source)
```
- 返回值
如果值为null，则返回当前时间
- 示例
```cs
var value = Datatime.Now.ToDateNow();
```
### .ToGuid() 转换为Guid
- 原型
```cs
public static Guid ToGuid<T>(this T source)
```
- 返回值
如果转换失败，返回Guid.Empty
- 示例
```cs
var value = "6F9619FF-8B86-D011-B42D-00C04FC964FF".ToGuid();
```
### .ToGuidNull() 转换为可空Guid
- 原型
```cs
public static Guid? ToGuidNull<T>(this T source)
```
- 返回值
如果值为null，则返回null
- 示例
```cs
var value = "6F9619FF-8B86-D011-B42D-00C04FC964FF".ToGuidNull();
```
### .ToEnum() 转换为枚举
- 原型
```cs
public static T ToEnum<T>(this object source)
```
- 返回值
如果转换失败，default(T)
- 示例
```cs
public enum UpdateType{
	Add = 1,
	Modify = 2,
	Delete = 3
}
var value = "Add".ToEnum<UpdateType>(); 
```
### .FormatString() 格式化字符串
- 原型
```cs
public static string FormatString(this string str, params object[] args)
```
- 返回值
与string.Format()一样
- 示例
```cs
var str = "未输入 {0} 和 {1}".FormatString("公司编号","公司名称");
```
### .IsEmpty() 判断字符串是否为空
- 原型
```cs
public static bool IsEmpty(this string str)
```
- 返回值
如果为null或空返回true，否则返回false
- 示例
```cs
var str = 'Test'
var isEmpty = str.IsEmpty();
```
### .IsId() 判断整数是否是Id（Id大于0）
- 原型
```cs
public static bool IsId(this int source)
```
- 返回值
如果值大于零返回true，否则返回false
- 示例
```cs
var id = 1;
if (id.IsId()){
   ...
}
```
### .EqualsIgnoreCase() 判断字符串是否匹配，忽略大小写
- 原型
```cs
public static bool EqualsIgnoreCase(this string str, string compareStr)
```
- 返回值
如果忽略大小写匹配，返回true，否则返回false
- 示例
```cs
var result = "Abc".EqualsIgnoreCase("ABC");
```
### .IsGuid() 判断字符串是否为Guid
- 原型
```cs
public static bool IsGuid(this string str)
```
- 返回值
判断字符串是否为Guid
- 示例
```cs
var result = "6F9619FF-8B86-D011-B42D-00C04FC964FF".IsGuid();
```
### .Split() 分割字符串
- 原型
```cs
public static string[] Split(this string str, string splitString)
```
- 返回值
与string.Split一致
- 示例
```cs
var items = "A,B,C".Split(",");
```
### .CopyToDataTable() 把DataRow行集合转化为DataTable
- 原型
```cs
public static DataTable CopyToDataTable(this IEnumerable<DataRow> rows, DataTable table)
```
- 返回值
返回DataTable
- 示例
```cs
var dt = new DataTable();
// 处理 dl
var rows = dt.AsEnumerable().Where(c=>!c["Name"].IsEmpty()).ToList();
var table = rows.CopyToDataTable();
```
### .ToSafeSqlInt() 转换为整数(SQL防注入)
- 原型
```cs
public static int ToSafeSqlInt<T>(this T source)
```
- 返回值
如果转换失败，返回0
- 示例
```cs
var value = "1234".ToInt();
```
### .ToSafeSqlDecimal() 转换为Decimal(SQL防注入)
- 原型
```cs
public static decimal ToSafeSqlDecimal<T>(this T source)
```
- 返回值
如果转换失败，返回0
- 示例
```cs
var value = "1234.56".ToSafeSqlDecimal();
```
### .ToSafeSqlStr() 转换为字符串(SQL防注入)
- 原型
```cs
public static string ToSafeSqlStr<T>(this T source)
```
- 返回值
如果值为null或空，返回string.Empty
- 示例
```cs
var value = "' drop table TestTable;".ToSafeSqlStr();
```
### .ToSafeDateNull() 转换为日期(SQL防注入)
- 原型
```cs
public static DateTime? ToSafeDateNull<T>(this T source)
```
- 返回值
如果转换失败，返回null
- 示例
```cs
var value = "2017-12-31".ToSafeDateNull();
```
### .GetValue() 字典Dictionary获取值
- 原型
```cs
public static TValue GetValue<TKey, TValue>(this Dictionary<TKey, TValue> source, TKey key)
```
- 返回值
如果key不存在，则返回default(TValue)
- 示例
```cs
var dict = new Dictionary<string,String>();
//...处理
var value = dict.GetValue('TestKey');
```
### .ToUpperString() 转换字符串为大写，常用于Guid转大写等
- 原型
```cs
public static string ToUpperString(this Guid source)
```
- 返回值
如果string.ToUpper()
- 示例
```cs
var str = "Abc".ToUpper(); // ABC
```
### .ToJsonString() DataTable转JSON
- 原型
```cs
public static string ToJsonString(this DataTable source)
```
- 返回值
返回JSON字符串
- 示例
```cs
DataTable data = null;
var str = data.ToJsonString();
```
### .FormatAmount() 格式化金额
- 原型
```cs
public static decimal FormatAmount<T>(this T amount)
```
- 返回值
返回JSON字符串
- 示例
```cs
decimal data = 1213.123;
var str = data.FormatAmount();//1213.12
```
