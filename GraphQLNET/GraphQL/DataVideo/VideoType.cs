using GraphQLNET.Models;

namespace GraphQLNET.GraphQL.DataVideo
{
    public class VideoType : ObjectType<Video>
    {
        protected override void Configure(IObjectTypeDescriptor<Video> descriptor)
        {
            descriptor.Description("Este modelo es usado como base la información de los videos");

            descriptor
                .Field(v => v.Id)
                .Description("Este es el identificador del video");

            descriptor
                .Field(v => v.Name)
                .Description("Este es el nombre del video");

            descriptor
                .Field(v => v.DirectorId)
                .Description("Este es el identificador del streamer");

            descriptor
                .Field(v => v.Director)
                .Description("Este es el streamer del video");

        }
    }
}
