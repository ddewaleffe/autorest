// Code generated by Microsoft (R) AutoRest Code Generator 1.2.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Searchservice.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Provides parameter values to a tag scoring function.
    /// </summary>
    public partial class TagScoringParameters
    {
        /// <summary>
        /// Initializes a new instance of the TagScoringParameters class.
        /// </summary>
        public TagScoringParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TagScoringParameters class.
        /// </summary>
        /// <param name="tagsParameter">Gets or sets the name of the parameter
        /// passed in search queries to specify the list of tags to compare
        /// against the target field.</param>
        public TagScoringParameters(string tagsParameter)
        {
            TagsParameter = tagsParameter;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the parameter passed in search queries to
        /// specify the list of tags to compare against the target field.
        /// </summary>
        [JsonProperty(PropertyName = "tagsParameter")]
        public string TagsParameter { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TagsParameter == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TagsParameter");
            }
        }
    }
}
