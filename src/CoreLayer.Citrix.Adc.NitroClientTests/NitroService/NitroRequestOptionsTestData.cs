using System.Collections;
using System.Collections.Generic;
using CoreLayer.Citrix.Adc.NitroClient;

namespace CoreLayer.Citrix.Adc.NitroClientTests.NitroService
{
    public class NitroRequestOptionsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NitroRequestOptionsDefault
                {
                    PropertyFilter = new List<string>()
                },
                string.Empty
            };
            yield return new object[]
            {
                new NitroRequestOptionsDefault
                {
                    PropertyFilter = {string.Empty}
                },
                string.Empty
            };
            yield return new object[]
            {
                new NitroRequestOptionsDefault
                {
                    PropertyFilter = {"item1"}
                },
                "?attrs=item1"
            };
            yield return new object[]
            {
                new NitroRequestOptionsDefault
                {
                    PropertyFilter = {"item1", string.Empty}
                },
                "?attrs=item1"
            };
            yield return new object[]
            {
                new NitroRequestOptionsDefault
                {
                    PropertyFilter = {"item1", "item2"}
                },
                "?attrs=item1,item2"
            };
            yield return new object[]
            {
                new NitroRequestOptionsDefault
                {
                    PropertyFilter = {string.Empty, "item2", "item3"}
                },
                "?attrs=item2,item3"
            };
            yield return new object[]
            {
                new NitroRequestOptionsDefault
                {
                    PropertyFilter = {"item1", string.Empty, "item3"}
                },
                "?attrs=item1,item3"
            };
            yield return new object[]
            {
                new NitroRequestOptionsDefault
                {
                    PropertyFilter = {"item1", "item2", string.Empty}
                },
                "?attrs=item1,item2"
            };
            yield return new object[]
            {
                new NitroRequestOptionsDefault
                {
                    PropertyFilter = {"item1","item2","item3"}
                },
                "?attrs=item1,item2,item3"
            };
            yield return new object[]
            {
                new NitroRequestOptionsDefault
                {
                    ResourceFilter = new Dictionary<string, string>()
                },
                string.Empty
            };
            yield return new object[]
            {
                new NitroRequestOptionsDefault
                {
                    ResourceFilter = {{"key1", string.Empty}}
                },
                string.Empty
            };
            yield return new object[]
            {
                new NitroRequestOptionsDefault
                {
                    ResourceFilter = {{"key1", "value1"}}
                },
                "?filter=key1:value1"
            };
            yield return new object[]
            {
                new NitroRequestOptionsDefault
                {
                    ResourceFilter = {{"key1", string.Empty}, {"key2", "value2"}}
                },
                "?filter=key2:value2"
            };
            yield return new object[]
            {
                new NitroRequestOptionsDefault
                {
                    ResourceFilter = {{"key1", "value1"}, {"key2", string.Empty}}
                },
                "?filter=key1:value1"
            };
            yield return new object[]
            {
                new NitroRequestOptionsDefault
                {
                    ResourceFilter = {{"key1", "value1"}, {"key2", "value2"}}
                },
                "?filter=key1:value1,key2:value2"
            };
            yield return new object[]
            {
                new NitroRequestOptionsDefault
                {
                    ResourceFilter = {{"key1", string.Empty}, {"key2", "value2"}, {"key3", "value3"}}
                },
                "?filter=key2:value2,key3:value3"
            };
            yield return new object[]
            {
                new NitroRequestOptionsDefault
                {
                    ResourceFilter = {{"key1", "value1"}, {"key2", string.Empty}, {"key3", "value3"}}
                },
                "?filter=key1:value1,key3:value3"
            };
            yield return new object[]
            {
                new NitroRequestOptionsDefault
                {
                    ResourceFilter = {{"key1", "value1"}, {"key2", "value2"}, {"key3", string.Empty}}
                },
                "?filter=key1:value1,key2:value2"
            };
            yield return new object[]
            {
                new NitroRequestOptionsDefault
                {
                    ResourceFilter = {{"key1", "value1"}, {"key2", "value2"}, {"key3", "value3"}}
                },
                "?filter=key1:value1,key2:value2,key3:value3"
            };
            yield return new object[]
            {
                new NitroRequestOptionsDefault
                {
                    PropertyFilter = {"item1"},
                    ResourceFilter = {{"key1","/value1/"}}
                },
                "?filter=key1:%2Fvalue1%2F&attrs=item1"
            };
            yield return new object[]
            {
                new NitroRequestOptionsDefault
                {
                    PropertyFilter = {"item1", "item2"},
                    ResourceFilter = {{"key1","value1"}, {"key2", "value2"}}
                },
                "?filter=key1:value1,key2:value2&attrs=item1,item2"
            };
            yield return new object[]
            {
                new NitroRequestOptionsDefault
                {
                    ResourceName = "instance1"
                },
                "/instance1"
            };
            yield return new object[]
            {
                new NitroRequestOptionsDefault
                {
                    ResourceName = "Instance1",
                    ResourceFilter = {{"key1", "value1"},{"key2", "value2"}},
                    PropertyFilter = {"item1", "item2"}
                }, 
                "/Instance1?filter=key1:value1,key2:value2&attrs=item1,item2"
            };
            yield return new object[]
            {
                new NitroRequestOptionsDefault
                {
                    Action = "enable"
                },
                "?action=enable"
            };
            yield return new object[]
            {
                new NitroRequestOptionsDefault
                {
                    Action = "enable",
                    PropertyFilter = {"item1"}
                },
                "?action=enable"
            };
            yield return new object[]
            {
                new NitroRequestOptionsDefault
                {
                    Count = true
                },
                "?count=yes"
            };
            yield return new object[]
            {
                new NitroRequestOptionsDefault
                {
                    Count = true,
                    PropertyFilter = {"filter"}
                },
                "?count=yes&attrs=filter"
            };
            yield return new object[]
            {
                new NitroRequestOptionsDefault
                {
                    Count = true,
                    ResourceName = "instance1"
                },
                "/instance1?count=yes"
            };
            
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}