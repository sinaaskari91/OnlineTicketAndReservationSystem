using DataTransferObject.DTOClasses;
using Infrastructure.RepositoryPattern;
using Mapster;
using Model.Entities;
using Service.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Service.ServiceClasses
{
    public class BlobService:IBlobService
    {
            private readonly IBaseRepository<Blob, Guid> _blobRepository;
            public BlobService(IBaseRepository<Blob, Guid> blobRepository)
            {
                _blobRepository = blobRepository;
            }

            public BlobDTO TranslateToDTO(Blob entity)
            {
                return entity.Adapt<BlobDTO>();
            }

            public Blob TranslateToEntity(BlobDTO dto)
            {
                return dto.Adapt<Blob>();
            }
        }
    }

