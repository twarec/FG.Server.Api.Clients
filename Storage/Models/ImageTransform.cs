namespace FG.Server.Api.Clients.Storage.Models;

public class ImageTransform
{
    public int? Quality { get; set; } //��������������� �� 0 �� 100
    public SizeOptions? Size { get; set; }  //�� ������ ��������
    public MaxSizeOptions? MaxSize { get; set; } //��������� �� ���� ����������
    public BoxSizeOptions? BoxSize { get; set; } //� ��������� xy

    public class SizeOptions
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }
    public class MaxSizeOptions
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }
    public class BoxSizeOptions
    {
        public int Size { get; set; }
        public BoxSizeType Type { get; set; } = BoxSizeType.Large;

        public enum BoxSizeType
        {
            Small,
            Large,
            Width,
            Height,
        }
    }
}
