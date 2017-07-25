namespace Portal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Collections.Generic;
    using Portal.Models;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            var judges = new List<Judge>
            {
                new Judge
                {
                    JudgeId = 1, Name = "Smokin Wanjala",
                    SatoriId = "e9e2d7b3-9a3a-49ad-90b2-9ee030ee7b93",
                    LastUpdated = DateTime.Now,
                    ImageUrl = "https://i0.wp.com/kenyanlife.com/wp-content/uploads/2016/04/Justice-Smokin-Wanjala-Biography-Supreme-Court-Judge-Willy-Mutunga-Education-Career-Business-salary-Parents-Family-wife-children-investments-300x300.jpg?resize=300%2C300",
                    Description = "Smokin Wanjala is a Kenyan lawyer and an Associate justice of the Supreme Court of Kenya. He holds a Ph.D. in law from University of Ghent, Belgium. He also holds a Master of Laws degree from the Columbia University in the United States of America and a Bachelor of Laws (LLB) degree from the University of Nairobi. Wanjala lectured at the University of Nairobi for 15 years, where he taught international law, international human rights law, land law and criminal law.",
                    Education = "Ghent University; Columbia University; University of Nairobi"
                },
                new Judge
                {
                    JudgeId = 2,
                    Name = "Walter Samuel Nkanu Onnoghen",
                    SatoriId = "e9e2d7b3-9a3a-49ad-90b2-9ee030ee7b93",
                    LastUpdated = DateTime.Now,
                    ImageUrl = "http://cdn1.dailypost.ng/wp-content/uploads/2016/12/Justice-Walter-Onnoghen-600x400.jpg",
                    Description = "Walter Samuel Nkanu Onnoghen, GCON (born 22 December 1950) is the Chief Justice of Nigeria since 2017. He graduated from the University of Ghana at Legon, Ghana in 1977 and from the Nigerian Law School in Lagos in 1978. Before joining the Supreme Court, he was a judge in Cross River State and a justice of the Court of Appeal.",
                    Education = "Nigerian Law School; University of Ghana"
                },
                new Judge
                {
                    JudgeId = 3,
                    Name = "Nwali Sylvester Ngwuta",
                    SatoriId = "b4f60aa0-0491-a53d-e767-9727de42c822",
                    LastUpdated = DateTime.Now,
                    ImageUrl = "http://www.scjgov.com/images/profiles/thumbnails/Hon.%20Justice%20Muntaka%20Connmassie07702393.jpg",
                    Description = "Nwali Sylvester Ngwuta, CFR is a Nigerian jurist and Justice of the Supreme Court of Nigeria. Justice Sylvester was born in 1951 Amofia-Ukawu, Onicha local government area of Ebonyi State, South-Eastern, Nigeria. He is an Ezza-speaking person by birth. He obtained a bachelor's degree in Law from Obafemi Awolowo University and was Call to the bar, the Nigerian bar in 1978 after he graduated from the Nigerian Law School"

                },
                new Judge
                {
                    JudgeId = 4,
                    Name = "Ibrahim Tanko Muhammad",
                    SatoriId = "31ed3ebb-9a2a-eb42-4a56-72bc7fe13418",
                    LastUpdated = DateTime.Now,
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRCicYhAfWHJh3svEXwb-VCMZ7_60mu3QUt-Yb2GBaSQyZ9XNNytw",
                    Description = "Ibrahim Tanko Muhammad, CON is a Nigerian jurist and Justice of the Supreme Court of Nigeria. He was formerly a Justice of the Nigerian courts of appeal. Justice Tanko was born on December 31, 1953 at Doguwa - Giade, a local government area in Bauchi State, Northern Nigeria. He attended Government Secondary School, Azare where he obtained the West Africa School Certificate in 1973 before he later proceeded to Ahmadu Bello University where he received a bachelor's degree in Law in 1980. He later obtained a Master and Doctorate degree from the same university in 1984 and 1998 respectively"

                },
                new Judge
                {
                    JudgeId = 5,
                    Name = "John Inyang Okoro",
                    SatoriId = "10c1ce68-35cf-cdf0-13d6-e400ec770db8",
                    LastUpdated = DateTime.Now,
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQph90In6utRgUSG6YianybFPIN9M8JiD6GnXBBhDRQ0Qv82Hk4EObQ5Uid",
                    Description = "John Inyang Okoro is a Nigerian jurist and Justice of the Supreme Court of Nigeria. His appointment as justice of the Supreme Court of Nigeria was confirmed by the Senate on October 2013. He was sworn in on November 15, 2014 by Justice Aloma Mariam Mukhtar, the former Chief Justice of Nigeria. He was arrested by the department of state security services, on 8 October 2016 on allegations of bribery and corruption"

                },
                new Judge
                {
                    JudgeId = 6,
                    Name = "Mary Odili",
                    SatoriId = "1b81256a-7738-2ae4-9015-6f2cef06fbf9",
                    LastUpdated = DateTime.Now,
                    ImageUrl = "http://pmnewsnigeria.com/wp-content/uploads/2011/02/Justice-Aloysius-Katsina-Al3.jpg",
                    Description = "Mary Ukaego Odili is a Nigerian judge and wife of Peter Odili, who served as Governor of Rivers State from 1999 to 2007. She was appointed an Associate Justice of the Supreme Court of Nigeria by President Goodluck Jonathan and was administered the oath of office by Chief Justice Katsina-Alu on 23 June 2011",
                    Education = "University of Nigeria, Nsukka; Nigerian Law School"
                },
                new Judge
                {
                    JudgeId = 7,
                    Name = "Bode Rhodes-Vivour",
                    SatoriId = "ca3b578a-a2db-8325-ef52-2e143a7bd065",
                    LastUpdated = DateTime.Now,
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSb2_ckHox8pxfv9y2EuKWDEMkZdwR4WiB7lz4Om2GwfRn7QTMoIw",
                    Description = "Bode Rhodes-Vivour, CFR is a Nigerian jurist and Justice of the Supreme Court of Nigeria. Justice Rhodes-vivour was born on March 22, 1951 in Lagos Island, a city of Lagos State western Nigeria. He obtained a bachelor's degree in Law from the University of Lagos in 1974 and was Call to the bar in 1975 after he graduated from the Nigerian Law School. In 1983, he proceeded to the University of Nairobi where he received a certificate in Legislative Drafting under the auspices of Commonwealth Programme"
                },
                new Judge
                {
                    JudgeId = 8,
                    Name = "Clara Bata Ogunbiyi",
                    SatoriId = "5dcd1f4f-46c2-e060-ecb9-b2d6c0493507",
                    LastUpdated = DateTime.Now,
                    ImageUrl = "http://venturesafrica.com/wp-content/uploads/2016/10/Justice-Ogunbiyi.jpg",
                    Description = "Clara Bata Ogunbiyi is a Nigerian jurist and Justice of the Supreme Court of Nigeria. Justice Clara was born on February 27, 1948 at Lassa, a town in Borno State, Northeastern Nigeria. She obtained a diploma certificate in Law from Ahmadu Bello University on June 1971 before she later enrolled for a bachelor's degree in Law from the same university on June 1975 and was Call to the bar, the Nigerian bar in 1976, the same year she graduated from the Nigerian Law School. She completed the compulsory one year Youth Service on June 1977. She proceeded to the University of Hull",
                },
                new Judge
                {
                    JudgeId = 9,
                    Name = "David Maraga",
                    SatoriId = "8f138c22-8ecc-391d-488c-4b27093193cf",
                    LastUpdated = DateTime.Now,
                    ImageUrl = "http://www.the-star.co.ke/sites/default/files/styles/new_full_content/public/articles/2016/10/19/1440853.jpg?itok=HdRKjoUH",
                    Description ="David Kenani Maraga (born in 1951), is a Kenyan lawyer and jurist. He is the Chief Justice and President of the Supreme Court of Kenya. He is the 14th Chief Justice of Kenya. Maraga was born in Bonyamatuta, Nyamira County, in 1951. He studied law at the University of Nairobi, and was awarded a Bachelor of Laws in 1977. Later, he obtained a Master of Laws from the university. He also holds a post graduate diploma awarded in 1978 by the Kenya School of Law.",
                    Religion = "Seventh Day Adventist"
                },
            };

            judges.ForEach(j => context.Judges.AddOrUpdate(p => p.Name, j));
            context.SaveChanges();

            var opinions = new List<Opinion>
            {
                new Opinion
                {
                    Title = "Harper & Row v. Nation Enterprises",
                    Url = "https://scholar.google.com/scholar_case?case=12801604581154452950&q=copyright+law&hl=en&as_sdt=3,48",
                    JudgeId = judges.First().JudgeId
                },
                new Opinion
                {
                    Title = "Harper & Row v. Nation Enterprises",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Supreme%20Court%202017/Petition%2017.2014%20Bichage.pdf",
                    JudgeId = judges.Last().JudgeId
                },
            };

            opinions.ForEach(j => context.Opinions.AddOrUpdate(p => p.Title, j));
            context.SaveChanges();
        }
    }
}
