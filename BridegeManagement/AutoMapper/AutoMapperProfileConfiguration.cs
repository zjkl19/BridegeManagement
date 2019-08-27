using AutoMapper;
using BridegeManagement.Models;
using System;

namespace BridegeManagement
{
    public class AutoMapperProfileConfiguration : Profile
    {
        public AutoMapperProfileConfiguration()
        {
            //CreateMap<Procedure, ProcedureViewModel>();
            //CreateMap<ProcedureViewModel, Procedure>();

            //CreateMap<CreateProcedureViewModel, Procedure>()
            //    .ForMember(d => d.Id, op => op.MapFrom(ax => Guid.NewGuid()));

            ////CreateMap<source, destination>()
            //CreateMap<CMProject, CMProjectViewModel>()
            //    .ForMember(dest => dest.EngineeringStatus, src => src.MapFrom(x =>x.EngineeringStatus))
            //    .ForMember(dest => dest.ResponseStaffName, src => src.MapFrom(x =>x.ResponseStaff.Name));
            ////p => p.EngineeringStatus, q => q.MapFrom(x => (EngineeringStatus)x.EngineeringStatus));

            //CreateMap<CMProject, EditCMProjectViewModel>();

            //CreateMap<EditCMProjectViewModel, CMProject>();
            ////.ForMember(dest => dest.Id, src =>src.Ignore());

            //CreateMap<Procedure, EditProcedureViewModel>();
            //CreateMap<EditProcedureViewModel, Procedure>();

            //CreateMap<StrainMonitor, StrainMonitorViewModel>()
            //    .ForMember(dest => dest.ProcedureName, src => src.MapFrom(x => x.Procedure.Name));
            //CreateMap<CreateStrainMonitorViewModel, StrainMonitor>()
            //    .ForMember(dest => dest.Id, src => src.MapFrom(x => Guid.NewGuid()));

            //CreateMap<CoordinateMonitor, CoordinateMonitorViewModel>()
            //    .ForMember(dest => dest.ProcedureName, src => src.MapFrom(x => x.Procedure.Name));
            //CreateMap<CreateCoordinateMonitorViewModel, CoordinateMonitor>()
            //    .ForMember(dest => dest.Id, src => src.MapFrom(x => Guid.NewGuid()));

            //CreateMap<ElevationMonitor, ElevationMonitorViewModel>()
            //    .ForMember(dest => dest.ProcedureName, src => src.MapFrom(x => x.Procedure.Name));
            //CreateMap<CreateElevationMonitorViewModel, ElevationMonitor>()
            //    .ForMember(dest => dest.Id, src => src.MapFrom(x => Guid.NewGuid()));

            //CreateMap<LeanMonitor, LeanMonitorViewModel>()
            //    .ForMember(dest => dest.ProcedureName, src => src.MapFrom(x => x.Procedure.Name));
            //CreateMap<CreateLeanMonitorViewModel, LeanMonitor>()
            //    .ForMember(dest => dest.Id, src => src.MapFrom(x => Guid.NewGuid()));

            //CreateMap<CableForceMonitor, CableForceMonitorViewModel>()
            //    .ForMember(dest => dest.ProcedureName, src => src.MapFrom(x => x.Procedure.Name));
            //CreateMap<CreateCableForceMonitorViewModel, CableForceMonitor>()
            //    .ForMember(dest => dest.Id, src => src.MapFrom(x => Guid.NewGuid()));
        }
    }
}