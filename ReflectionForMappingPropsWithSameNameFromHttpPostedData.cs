using AutoMapper;
using FilingPortal.Domain.DTOs.VesselExport;
using FilingPortal.PluginEngine.Models;
using FilingPortal.Web.Models.VesselExport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace FilingPortal.Web.Mapping
{
    public class VesselExportModelsMapper
    {
        private static readonly Dictionary<Type, Func<object, object>> parsingActions = new Dictionary<Type, Func<object, object>>()
                    {
                     {typeof(int), x => {return int.Parse(x.ToString());}},
                     {typeof(int?), x => {return int.Parse(x.ToString());}},
                     {typeof(decimal?), x => {return decimal.Parse(x.ToString());}},
                     {typeof(decimal), x => {return decimal.Parse(x.ToString());}},
                     {typeof(string), x => {return x.ToString(); }}
                    };


        public static VesselExportEditModel FromHttpPostedDataToEditModel(HttpPostedData data)
        {
            VesselExportEditModel model = new VesselExportEditModel();

            PropertyInfo[] properties = typeof(VesselExportEditModel).GetProperties();
            foreach (var prop in properties)
            {
                if (!data.Fields.TryGetValue(prop.Name, out _))
                {
                    prop.SetValue(model, null);
                }
                else
                {
                    parsingActions.TryGetValue(prop.PropertyType, out var propertyVal);
                    if (!string.IsNullOrWhiteSpace(data.Fields[prop.Name]?.Value))
                    {
                        prop.SetValue(model, propertyVal.Invoke(data.Fields[prop.Name]?.Value));
                    }
                }
                model.Documents = new List<VesselExportDocumentDto>();
            }

            if (data.Files.Count > 0)
            {
                model.Documents.Add(Mapper.Map<VesselExportDocumentDto>(data));
            }

            return model;
        }

        public static VesselExportCreateAssignModel FromHttpPostedDataToCreateAssignModel(HttpPostedData data)
        {

            VesselExportCreateAssignModel model = new VesselExportCreateAssignModel();

            PropertyInfo[] properties = typeof(VesselExportCreateAssignModel).GetProperties();
            foreach (var prop in properties)
            {
                if (!data.Fields.TryGetValue(prop.Name, out _))
                {
                    prop.SetValue(model, null);
                }
                else
                {
                    parsingActions.TryGetValue(prop.PropertyType, out var propertyVal);
                    if (!string.IsNullOrWhiteSpace(data.Fields[prop.Name]?.Value))
                    {
                        prop.SetValue(model, propertyVal.Invoke(data.Fields[prop.Name]?.Value));
                    }
                }
                model.Documents = new List<VesselExportDocumentDto>();
            }

            if (data.Files.Count > 0)
            {
                model.Documents.Add(Mapper.Map<VesselExportDocumentDto>(data));
            }

            return model;
        }
        public static string TryGetDocumentValue(IDictionary<string, HttpPostedField> dict, string searchBy)
        {
            dict.TryGetValue(searchBy, out HttpPostedField val);
            return val?.Value;
        }
    }
}
