using System;

namespace DecoratorExample
{ 
    public class ImageData
    {
        public string Name { get; set; }

        public ImageData(string name)
        {
            Name = name;
        }
    }
    public interface IImage
    {
        string GetDescription();
        ImageData Process();
    }

    public class BaseImage : IImage
    {
        private readonly ImageData _image;

        public BaseImage(string imageName)
        {
            _image = new ImageData(imageName);
        }

        public string GetDescription()
        {
            return $"Исходное изображение: {_image.Name}";
        }

        public ImageData Process()
        {
            Console.WriteLine($"Загружено изображение: {_image.Name}");
            return _image;
        }
    }

    public abstract class ImageDecorator : IImage
    {
        protected IImage image;

        protected ImageDecorator(IImage image)
        {
            this.image = image;
        }

        public virtual string GetDescription()
        {
            return image.GetDescription();
        }

        public virtual ImageData Process()
        {
            return image.Process();
        }
    }

    public class BlackWhiteFilterDecorator : ImageDecorator
    {
        public BlackWhiteFilterDecorator(IImage image) : base(image)
        {
        }

        public override string GetDescription()
        {
            return image.GetDescription() + " + черно-белый фильтр";
        }

        public override ImageData Process()
        {
            ImageData result = image.Process();
            Console.WriteLine("Применён черно-белый фильтр.");
            return result;
        }
    }

    public class BlurFilterDecorator : ImageDecorator
    {
        public BlurFilterDecorator(IImage image) : base(image)
        {
        }

        public override string GetDescription()
        {
            return image.GetDescription() + " + размытие";
        }

        public override ImageData Process()
        {
            ImageData result = image.Process();
            Console.WriteLine("Применён фильтр размытия.");
            return result;
        }
    }

    public class SharpenFilterDecorator : ImageDecorator
    {
        public SharpenFilterDecorator(IImage image) : base(image)
        {
        }

        public override string GetDescription()
        {
            return image.GetDescription() + " + повышение резкости";
        }

        public override ImageData Process()
        {
            ImageData result = image.Process();
            Console.WriteLine("Применён фильтр резкости.");
            return result;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            IImage image = new BaseImage("photo.jpg");

            Console.WriteLine("Обычное изображение:");
            Console.WriteLine(image.GetDescription());
            image.Process();

            Console.WriteLine();

            IImage filteredImage = new SharpenFilterDecorator(
                                        new BlurFilterDecorator(
                                            new BlackWhiteFilterDecorator(
                                                new BaseImage("landscape.png"))));

            Console.WriteLine("Изображение с несколькими фильтрами:");
            Console.WriteLine(filteredImage.GetDescription());
            filteredImage.Process();
        }
    }
}