using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Limbo.DataAccess.Services.Models;
using Limbo.MailSystem.MailTemplates.Services;
using Limbo.MailSystem.Persisence.MailSegments.Models;
using Limbo.MailSystem.Persisence.MailTemplates.Models;
using Limbo.MailSystem.Persisence.SegmentTypes.Models;
using Limbo.MailSystem.SegmentTypes.Services;
using Limbo.MailSystem.Templates.SimpleText.Constants;
using Microsoft.EntityFrameworkCore;

namespace Limbo.MailSystem.Templates.SimpleText.Services {
    /// <inheritdoc/>
    public class SimpleTextService : ISimpleTextService {
        private readonly IMailTemplateService _mailTemplateService;
        private readonly ISegmentTypeService _segmentTypeService;

        /// <inheritdoc/>
        public SimpleTextService(IMailTemplateService mailTemplateService, ISegmentTypeService segmentTypeService) {
            _mailTemplateService = mailTemplateService;
            _segmentTypeService = segmentTypeService;
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<MailTemplate>> CreateTemplate(string name, string content) {
            SegmentType segmentType = await GetSegmentType();

            var mailTemplate = new MailTemplate {
                Name = name,
                MailSegments = new List<MailSegment> {
                    new MailSegment {
                        NVarCharMaxValue = content,
                        SegmentType = segmentType
                    }
                }
            };
            return await _mailTemplateService.Add(mailTemplate);
        }

        private async Task<SegmentType> GetSegmentType() {
            var segmentType = (await _segmentTypeService.QueryDbSet()).ResponseValue?.FirstOrDefault(item => item.Alias == SimpleTextConstants.SimpleTextSegmentTypeAlias);
            if (segmentType == null) {
                segmentType = new SegmentType {
                    Alias = SimpleTextConstants.SimpleTextSegmentTypeAlias
                };
            }

            return segmentType;
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<MailTemplate>?> UpdateTemplateContent(int id, string content) {
            var mailTemplate = (await _mailTemplateService.QueryDbSet()).ResponseValue.Include(item => item.MailSegments).FirstOrDefault(item => item.Id == id);
            if (mailTemplate == null) {
                return null;
            }

            var segment = mailTemplate.MailSegments?.FirstOrDefault();
            if (segment != null) {
                segment.NVarCharMaxValue = content;
            }

            return await _mailTemplateService.Update(mailTemplate);
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<MailTemplate>> DeleteTemplate(int id) {
            return await _mailTemplateService.DeleteById(id);
        }

        /// <inheritdoc/>
        public virtual async Task<MailTemplate?> GetTemplate(int id) {
            return (await _mailTemplateService.QueryDbSet()).ResponseValue.Include(item => item.MailSegments).ThenInclude(item => item.SegmentType).FirstOrDefault(item => item.Id == id);
        }
    }
}
