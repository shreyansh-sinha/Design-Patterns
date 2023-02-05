namespace Factory_Method
{
    public static class Factory
    {
        public static HiringManager GetInterviewer(string type)
        {
            switch(type)
            {
                case "Development":
                    return new DevelopmentManager();
                case "Executive":
                    return new ExecutiveManager();
            }

            return null;
        }
    }
}
