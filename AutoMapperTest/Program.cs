using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text.Json.Serialization;
using AutoMapper;
using Newtonsoft.Json;

namespace AutoMapperTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<TestRunner>();

//            var t = new TestClass();
//            t.ManualMapper();
//            t.AutoMapper();
//            t.JsonMapper();
        }
    }

    [ClrJob, MonoJob, CoreJob] // 可以針對不同的 CLR 進行測試
    [MinColumn, MaxColumn]
    [MemoryDiagnoser]
    public class TestRunner
    {
        private readonly TestClass _test = new TestClass();

        [Benchmark]
        public void ManualMapper() => _test.ManualMapper();

        [Benchmark]
        public void AutoMapper() => _test.AutoMapper();
        
        [Benchmark]
        public void JsonMapper() => _test.JsonMapper();
    }

    public class TestClass
    {
        private Class1[] _dtos;
        private IMapper _mapper;

        public TestClass()
        {
            var dto = GetInstance<Class1>();
            _dtos = Enumerable.Repeat(dto, 100).ToArray();
            
            var mockMapper = new MapperConfiguration(cfg => cfg.AddProfile(new AutoMapperProfile()));
            _mapper = mockMapper.CreateMapper();
        }
        
        public Class2[] ManualMapper()
        {
            var result = _dtos.Select(c1 => new Class2
                                                  {
                                                      Property00 =  c1.Property00,
                                                      Property01 =  c1.Property01,
                                                      Property02 =  c1.Property02,
                                                      Property03 =  c1.Property03,
                                                      Property04 =  c1.Property04,
                                                      Property05 =  c1.Property05,
                                                      Property06 =  c1.Property06,
                                                      Property07 =  c1.Property07,
                                                      Property08 =  c1.Property08,
                                                      Property09 =  c1.Property09,
                                                      Property10 =  c1.Property10,
                                                      Property11 =  c1.Property11,
                                                      Property12 =  c1.Property12,
                                                      Property13 =  c1.Property13,
                                                      Property14 =  c1.Property14,
                                                      Property15 =  c1.Property15,
                                                      Property16 =  c1.Property16,
                                                      Property17 =  c1.Property17,
                                                      Property18 =  c1.Property18,
                                                      Property19 =  c1.Property19,
                                                      Property20 =  c1.Property20,
                                                      Property21 =  c1.Property21,
                                                      Property22 =  c1.Property22,
                                                      Property23 =  c1.Property23,
                                                      Property24 =  c1.Property24,
                                                      Property25 =  c1.Property25,
                                                      Property26 =  c1.Property26,
                                                      Property27 =  c1.Property27,
                                                      Property28 =  c1.Property28,
                                                      Property29 =  c1.Property29,
                                                      Property30 =  c1.Property30,
                                                      Property31 =  c1.Property31,
                                                      Property32 =  c1.Property32,
                                                      Property33 =  c1.Property33,
                                                      Property34 =  c1.Property34,
                                                      Property35 =  c1.Property35,
                                                      Property36 =  c1.Property36,
                                                      Property37 =  c1.Property37,
                                                      Property38 =  c1.Property38,
                                                      Property39 =  c1.Property39,
                                                      Property40 =  c1.Property40,
                                                      Property41 =  c1.Property41,
                                                      Property42 =  c1.Property42,
                                                      Property43 =  c1.Property43,
                                                      Property44 =  c1.Property44,
                                                      Property45 =  c1.Property45,
                                                      Property46 =  c1.Property46,
                                                      Property47 =  c1.Property47,
                                                      Property48 =  c1.Property48,
                                                      Property49 =  c1.Property49,
                                                      Property50 =  c1.Property50,
                                                      Property51 =  c1.Property51,
                                                      Property52 =  c1.Property52,
                                                      Property53 =  c1.Property53,
                                                      Property54 =  c1.Property54,
                                                      Property55 =  c1.Property55,
                                                      Property56 =  c1.Property56,
                                                      Property57 =  c1.Property57,
                                                      Property58 =  c1.Property58,
                                                      Property59 =  c1.Property59,
                                                      Property60 =  c1.Property60,
                                                      Property61 =  c1.Property61,
                                                      Property62 =  c1.Property62,
                                                      Property63 =  c1.Property63,
                                                      Property64 =  c1.Property64,
                                                      Property65 =  c1.Property65,
                                                      Property66 =  c1.Property66,
                                                      Property67 =  c1.Property67,
                                                      Property68 =  c1.Property68,
                                                      Property69 =  c1.Property69,
                                                      Property70 =  c1.Property70,
                                                      Property71 =  c1.Property71,
                                                      Property72 =  c1.Property72,
                                                      Property73 =  c1.Property73,
                                                      Property74 =  c1.Property74,
                                                      Property75 =  c1.Property75,
                                                      Property76 =  c1.Property76,
                                                      Property77 =  c1.Property77,
                                                      Property78 =  c1.Property78,
                                                      Property79 =  c1.Property79,
                                                      Property80 =  c1.Property80,
                                                      Property81 =  c1.Property81,
                                                      Property82 =  c1.Property82,
                                                      Property83 =  c1.Property83,
                                                      Property84 =  c1.Property84,
                                                      Property85 =  c1.Property85,
                                                      Property86 =  c1.Property86,
                                                      Property87 =  c1.Property87,
                                                      Property88 =  c1.Property88,
                                                      Property89 =  c1.Property89,
                                                      Property90 =  c1.Property90,
                                                      Property91 =  c1.Property91,
                                                      Property92 =  c1.Property92,
                                                      Property93 =  c1.Property93,
                                                      Property94 =  c1.Property94,
                                                      Property95 =  c1.Property95,
                                                      Property96 =  c1.Property96,
                                                      Property97 =  c1.Property97,
                                                      Property98 =  c1.Property98,
                                                      Property99 =  c1.Property99,
                                                  }).ToArray();
            return result;
        }

        public Class2[] AutoMapper()
        {
            var result = _dtos.Select(dto =>  _mapper.Map<Class2>(dto)).ToArray();
            return result;
        }
        
        private T GetInstance<T>()
        {
            Type sourceType = typeof(T);

            var targetType = typeof(Class1);
            object result = targetType.InvokeMember(null, System.Reflection.BindingFlags.CreateInstance, null, null, null);

            foreach (var i in Enumerable.Range(0,100))
            {
                var propertyName = $"Property{i:00}";
                PropertyInfo propertyInfo = targetType.GetProperty(propertyName);
                if (propertyInfo != null)
                {
                    propertyInfo.SetValue(result, propertyName, null);
                }
            }

            return (T)result;
        }

        public Class2[] JsonMapper()
        {
            var json1 = JsonConvert.SerializeObject(_dtos);
            var result = JsonConvert.DeserializeObject<Class2[]>(json1);
            return result;
        }
    }
}