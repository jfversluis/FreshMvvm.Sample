using System;

namespace FreshMvvm.Sample.PageModels
{
    public class UnicornPageModel : FreshBasePageModel
    {
        public string ImagePath { get; private set; }

        public override void Init(object initData)
        {
            base.Init(initData);

            var imagePath = initData as string;

            if (string.IsNullOrWhiteSpace(imagePath))
            {
                CoreMethods.DisplayAlert("Error!", "Not an image path!", "OK");
                return;
            }

            ImagePath = imagePath;
            RaisePropertyChanged("ImagePath");
        }
    }
}