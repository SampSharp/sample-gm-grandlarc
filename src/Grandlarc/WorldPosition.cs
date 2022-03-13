using SampSharp.GameMode;

namespace Grandlarc
{
    public struct WorldPosition
    {
        public Vector3 Position;
        public float Rotation;

        public WorldPosition(Vector3 position, float rotation)
        {
            Position = position;
            Rotation = rotation;
        }
    }
}