using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Internal;
using Microsoft.AspNetCore.Mvc.Filters;
using YL.NetCore.Attributes;

namespace YL.NetCore.DI
{
    /// <summary>
    /// ����ʵ������ע���FilterProvider
    /// /// ���͵�ַ:https://www.cnblogs.com/wiseant/p/10515842.html
    ///��Դ��ַhttps://gitee.com/xant77/CustomAuthorization.WebApi
    /// </summary>
    /// <remarks>
    /// **�÷�**
    /// ��Startup.ConfigureServices()�������������һ�д��룺
    ///// services.Replace(ServiceDescriptor.Transient<IFilterProvider, PropertiesAutowiredFilterProvider>());
    /// </remarks>
    public class PropertiesAutowiredFilterProvider : DefaultFilterProvider
    {
        private static IDictionary<string, IEnumerable<PropertyInfo>> _publicPropertyCache = new Dictionary<string, IEnumerable<PropertyInfo>>();

        public override void ProvideFilter(FilterProviderContext context, FilterItem filterItem)
        {
            base.ProvideFilter(context, filterItem); //�ڵ��û��෽��֮ǰfilterItem����������ֵ
            var filterType = filterItem.Filter.GetType();
            if (!_publicPropertyCache.ContainsKey(filterType.FullName))
            {
                var ps = filterType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic)
                    .Where(c => c.GetCustomAttribute<InjectionAttribute>() != null);
                _publicPropertyCache[filterType.FullName] = ps;
            }

            var injectionProperties = _publicPropertyCache[filterType.FullName];
            if (injectionProperties?.Count() == 0)
                return;
            //������ע������ʵ���Ĺؼ�����
            var serviceProvider = context.ActionContext.HttpContext.RequestServices;
            foreach (var item in injectionProperties)
            {
                var service = serviceProvider.GetService(item.PropertyType);
                if (service == null)
                {
                    throw new InvalidOperationException($"Unable to resolve service for type '{item.PropertyType.FullName}' while attempting to activate '{filterType.FullName}'");
                }
                item.SetValue(filterItem.Filter, service);
            }

            foreach (FieldInfo field in filterType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
            {
                var autowiredAttr = field.GetCustomAttribute<InjectionAttribute>();
                if (autowiredAttr != null)
                {
                    field.SetValue(filterItem.Filter, serviceProvider.GetService(field.FieldType));
                }
            }
        }
    }
}