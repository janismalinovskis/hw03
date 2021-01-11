namespace shapes
{
    class rectangle
    {
        //lauki
        private int len;

        private int width;


        // konstruktors

        public rectangle()
        {

        }
        public rectangle(int len)
        {
            this.width = len;
            this.len = len;
        }




        public rectangle(int len, int width)
        {
            this.len = len;
            this.width = width;

        }




        //metodes
        public int getlen()
        {
            return len;
        }
        public int getwidth()
        {
            return width;

        }



        public bool issquare()
        {

            if (len == width)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public int area()
        {
            return (len * width);
        }
        public int perimeter()
        {
            return ((len + width) * 2);
        }

        public override string ToString()
        {
            return $"garums:  {len}  platums:  {width} vai ir kvadrats? {issquare()} laukums {area()} perimetrs {perimeter()}";
        }



    }

}