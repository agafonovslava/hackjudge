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
                    Jurisdiction= "Supreme Court",
                    JudicalSystem = "Mixed",
                    ImageUrl = "https://i0.wp.com/kenyanlife.com/wp-content/uploads/2016/04/Justice-Smokin-Wanjala-Biography-Supreme-Court-Judge-Willy-Mutunga-Education-Career-Business-salary-Parents-Family-wife-children-investments-300x300.jpg?resize=300%2C300",
                    Description = "Smokin Wanjala is a Kenyan lawyer and an Associate justice of the Supreme Court of Kenya. He holds a Ph.D. in law from University of Ghent, Belgium. He also holds a Master of Laws degree from the Columbia University in the United States of America and a Bachelor of Laws (LLB) degree from the University of Nairobi. Wanjala lectured at the University of Nairobi for 15 years, where he taught international law, international human rights law, land law and criminal law.",
                    Education = "Ghent University; Columbia University; University of Nairobi",
                    NumberOfCases = 30,
                    Language = "Kiswahili, English",
                    Born = "June 22, 1960 (age 57), Machakos, Kenya",
                    Country = "Kenya",
                },
                new Judge
                {
                    JudgeId = 2,
                    Name = "Walter Samuel Nkanu Onnoghen",
                    SatoriId = "e9e2d7b3-9a3a-49ad-90b2-9ee030ee7b93",
                    LastUpdated = DateTime.Now,
                    Jurisdiction= "Supreme Court",
                    JudicalSystem = "Mixed",
                    ImageUrl = "http://cdn1.dailypost.ng/wp-content/uploads/2016/12/Justice-Walter-Onnoghen-600x400.jpg",
                    Description = "Walter Samuel Nkanu Onnoghen, GCON (born 22 December 1950) is the Chief Justice of Nigeria since 2017. He graduated from the University of Ghana at Legon, Ghana in 1977 and from the Nigerian Law School in Lagos in 1978. Before joining the Supreme Court, he was a judge in Cross River State and a justice of the Court of Appeal.",
                    Education = "Nigerian Law School; University of Ghana",
                    NumberOfCases = 25,
                    Language = "Kiswahili, English",
                    Born = "December 22, 1950 (age 66), Cross River State, Nigeria",
                    Country = "Nigeria",
                },
                new Judge
                {
                    JudgeId = 3,
                    Name = "Nwali Sylvester Ngwuta",
                    SatoriId = "b4f60aa0-0491-a53d-e767-9727de42c822",
                    LastUpdated = DateTime.Now,
                    Jurisdiction= "Supreme Court",
                    JudicalSystem = "Mixed",
                    ImageUrl = "http://www.scjgov.com/images/profiles/thumbnails/Hon.%20Justice%20Muntaka%20Connmassie07702393.jpg",
                    Description = "Nwali Sylvester Ngwuta, CFR is a Nigerian jurist and Justice of the Supreme Court of Nigeria. Justice Sylvester was born in 1951 Amofia-Ukawu, Onicha local government area of Ebonyi State, South-Eastern, Nigeria. He is an Ezza-speaking person by birth. He obtained a bachelor's degree in Law from Obafemi Awolowo University and was Call to the bar, the Nigerian bar in 1978 after he graduated from the Nigerian Law School",
                    NumberOfCases = 20,
                    Language = "Kiswahili, English",
                    Born = "1951, Ebonyi State, Nigeria",
                    Country = "Nigeria",
                    Education = "Nigerian Law School",
                },
                new Judge
                {
                    JudgeId = 4,
                    Name = "Ibrahim Tanko Muhammad",
                    SatoriId = "31ed3ebb-9a2a-eb42-4a56-72bc7fe13418",
                    LastUpdated = DateTime.Now,
                    Jurisdiction= "Supreme Court",
                    JudicalSystem = "Mixed",
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRCicYhAfWHJh3svEXwb-VCMZ7_60mu3QUt-Yb2GBaSQyZ9XNNytw",
                    Description = "Ibrahim Tanko Muhammad, CON is a Nigerian jurist and Justice of the Supreme Court of Nigeria. He was formerly a Justice of the Nigerian courts of appeal. Justice Tanko was born on December 31, 1953 at Doguwa - Giade, a local government area in Bauchi State, Northern Nigeria. He attended Government Secondary School, Azare where he obtained the West Africa School Certificate in 1973 before he later proceeded to Ahmadu Bello University where he received a bachelor's degree in Law in 1980. He later obtained a Master and Doctorate degree from the same university in 1984 and 1998 respectively",
                    NumberOfCases = 12,
                    Language = "Kiswahili, English",
                    Born = "December 31, 1953 (age 63)",
                    Country = "Nigeria",
                    Education = "Ahmadu Bello University"
                },
                new Judge
                {
                    JudgeId = 5,
                    Name = "John Inyang Okoro",
                    SatoriId = "10c1ce68-35cf-cdf0-13d6-e400ec770db8",
                    LastUpdated = DateTime.Now,
                    Jurisdiction= "Supreme Court",
                    JudicalSystem = "Mixed",
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQph90In6utRgUSG6YianybFPIN9M8JiD6GnXBBhDRQ0Qv82Hk4EObQ5Uid",
                    Description = "John Inyang Okoro is a Nigerian jurist and Justice of the Supreme Court of Nigeria. His appointment as justice of the Supreme Court of Nigeria was confirmed by the Senate on October 2013. He was sworn in on November 15, 2014 by Justice Aloma Mariam Mukhtar, the former Chief Justice of Nigeria. He was arrested by the department of state security services, on 8 October 2016 on allegations of bribery and corruption",
                    NumberOfCases = 10,
                    Language = "Kiswahili, English",
                    Born = "July 11, 1959 (age 58), Akwa Ibom State, Nigeria",
                    Country = "Nigeria",
                },
                new Judge
                {
                    JudgeId = 6,
                    Name = "Mary Odili",
                    SatoriId = "1b81256a-7738-2ae4-9015-6f2cef06fbf9",
                    LastUpdated = DateTime.Now,
                    Jurisdiction= "Supreme Court",
                    JudicalSystem = "Mixed",
                    ImageUrl = "http://pmnewsnigeria.com/wp-content/uploads/2011/02/Justice-Aloysius-Katsina-Al3.jpg",
                    Description = "Mary Ukaego Odili is a Nigerian judge and wife of Peter Odili, who served as Governor of Rivers State from 1999 to 2007. She was appointed an Associate Justice of the Supreme Court of Nigeria by President Goodluck Jonathan and was administered the oath of office by Chief Justice Katsina-Alu on 23 June 2011",
                    Education = "University of Nigeria, Nsukka; Nigerian Law School",
                    NumberOfCases = 7,
                    Language = "English",
                    Born = "May 12, 1952 (age 65), Ezinihitte-Mbaise",
                    Country = "Nigeria"
                },
                new Judge
                {
                    JudgeId = 7,
                    Name = "Bode Rhodes-Vivour",
                    SatoriId = "ca3b578a-a2db-8325-ef52-2e143a7bd065",
                    LastUpdated = DateTime.Now,
                    JudicalSystem = "Mixed",
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSb2_ckHox8pxfv9y2EuKWDEMkZdwR4WiB7lz4Om2GwfRn7QTMoIw",
                    Description = "Bode Rhodes-Vivour, CFR is a Nigerian jurist and Justice of the Supreme Court of Nigeria. Justice Rhodes-vivour was born on March 22, 1951 in Lagos Island, a city of Lagos State western Nigeria. He obtained a bachelor's degree in Law from the University of Lagos in 1974 and was Call to the bar in 1975 after he graduated from the Nigerian Law School. In 1983, he proceeded to the University of Nairobi where he received a certificate in Legislative Drafting under the auspices of Commonwealth Programme",
                    NumberOfCases = 8,
                    Language = "English",
                    Born = "March 22, 1951 (age 66)",
                    Country = "Nigeria",
                    Education = "B.S. in Law from the University of Lagos",
                    Jurisdiction = "Supreme Court",
                },
                new Judge
                {
                    JudgeId = 8,
                    Name = "Clara Bata Ogunbiyi",
                    SatoriId = "5dcd1f4f-46c2-e060-ecb9-b2d6c0493507",
                    LastUpdated = DateTime.Now,
                    Jurisdiction= "Supreme Court",
                    JudicalSystem = "Common Law",
                    ImageUrl = "http://venturesafrica.com/wp-content/uploads/2016/10/Justice-Ogunbiyi.jpg",
                    Description = "Clara Bata Ogunbiyi is a Nigerian jurist and Justice of the Supreme Court of Nigeria. Justice Clara was born on February 27, 1948 at Lassa, a town in Borno State, Northeastern Nigeria. She obtained a diploma certificate in Law from Ahmadu Bello University on June 1971 before she later enrolled for a bachelor's degree in Law from the same university on June 1975 and was Call to the bar, the Nigerian bar in 1976, the same year she graduated from the Nigerian Law School. She completed the compulsory one year Youth Service on June 1977. She proceeded to the University of Hull",
                    NumberOfCases = 5,
                    Language = "English",
                    Born = "February 27, 1948 (age 69), Borno State, Nigeria",
                    Country = "Nigeria"
                },
                new Judge
                {
                    JudgeId = 9,
                    Name = "David Maraga",
                    SatoriId = "8f138c22-8ecc-391d-488c-4b27093193cf",
                    LastUpdated = DateTime.Now,
                    Jurisdiction= "Supreme Court",
                    JudicalSystem = "Mixed",
                    ImageUrl = "http://www.the-star.co.ke/sites/default/files/styles/new_full_content/public/articles/2016/10/19/1440853.jpg?itok=HdRKjoUH",
                    Description ="David Kenani Maraga (born in 1951), is a Kenyan lawyer and jurist. He is the Chief Justice and President of the Supreme Court of Kenya. He is the 14th Chief Justice of Kenya. Maraga was born in Bonyamatuta, Nyamira County, in 1951. He studied law at the University of Nairobi, and was awarded a Bachelor of Laws in 1977. Later, he obtained a Master of Laws from the university. He also holds a post graduate diploma awarded in 1978 by the Kenya School of Law.",
                    NumberOfCases = 50,
                    Language = "English",
                    Education = "University of Nairobi",
                    Born = "January 12, 1951 (age 66), Nyamira, Kenya",
                    Country = "Kenya",
                },
            };

            judges.ForEach(j => context.Judges.AddOrUpdate(p => p.Name, j));
            context.SaveChanges();

            var firstJudge = judges.Last().JudgeId;

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
                new Opinion
                {
                    Title = "Harper & Row v. Nation Enterprises",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Supreme%20Court%202017/Petition%2017.2014%20Bichage.pdf",
                    JudgeId = firstJudge
                },
                new Opinion
                {
                    Title = "1 - FINAL ORDERS BY CJ.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Decisions - SC/1- FINAL ORDERS BY CJ.pdf",
                    JudgeId = firstJudge
                },
                new Opinion
                {
                    Title = "2 - Ibrahim Js Opinion.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Decisions - SC/2 - Ibrahim Js Opinion.pdf",
                    JudgeId = 2
                },
                new Opinion
                {
                    Title = "23 Criminal Application 34 of 2014 DPP v Ahmed Mohammed Omar.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Supreme Court 2017/23 Criminal Application 34 of 2014 DPP v Ahmed Mohammed Omar.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "24 Application 1 of 2016 Joseph Kinyua v Pauline Wandia Kinyua.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Supreme Court 2017/24 Application 1 of 2016 Joseph Kinyua v Pauline Wandia Kinyua.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "24 Application 10 of 2016 Parliamentary Service Commission v Martin Wambora.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Supreme Court 2017/24 Application 10 of 2016 Parliamentary Service Commission v Martin Wambora.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "24 Application No 19 of 2016 Mutanga Tea and Coffee-min.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Supreme Court 2017/24 Application No 19 of 2016 Mutanga Tea and Coffee-min.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "24 Application No 7A of 2016 Okongo Oyugi v Obado and others.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Supreme Court 2017/24 Application No 7A of 2016 Okongo Oyugi v Obado and others.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "3 - Ruling on P.O. 11 and 12 of 2016.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Decisions - SC/3 - Ruling on P.O. 11 and 12 of 2016.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "4 - ruling on P.O.No.12 of 2016.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Decisions - SC/4- ruling on P.O. No.12 of 2016.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "6 - Wanjala PO Ruling -14 June 2016.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Decisions - SC/6 - Wanjala PO Ruling - 14 June 2016.pdf",
                    JudgeId = 1
                },
                new Opinion
                {
                    Title = "APPLICATION NO 4 OF 2012 - amended ruling.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/files/Rulings/APPLICATION NO 4 OF 2012-amended ruling.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Application No. 1 of 2013..with concurring ruling of the DCJ.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/files/Rulings/Application No. 1 of 2013.. with concurring ruling of the DCJ.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Application No. 15 of 2014, mwashetani..pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/files/Rulings/Application No. 15 of 2014, mwashetani..pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "APPLN NO. 1 OF 2011 sum model industries - RUling.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/files/Rulings/APPLN NO. 1 OF 2011 sum model industries-RUling.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "BASIL Ruling.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Court Decisions/BASIL Ruling.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "CCK COMPLIANCE - FINAL - 12 - 2 - 2015.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Court Decisions/CCK COMPLIANCE - FINAL - 12-2-2015.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "civil application No. 1 of 2012(ruling).pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/files/Rulings/civil application No. 1 of 2012 (ruling).pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Civil Application No. 23 of 2015 KRA v Habimana and Others.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Supreme Court 2017/Civil Application No. 23 of 2015 KRA v Habimana and Others.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Civil Application No. 3 of 2016 Kisumu executive.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/A - Decisions/Civil Application No. 3 of 2016 Kisumu executive.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Corrected judgment - Petition 5 of 2013.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/files/Supreme Court/Corrected judgment-Petition 5 of 2013.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "digital migration ruling final.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/files/Rulings/digital migration ruling final.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Dissenting Opinion - One Third Rule.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/files/Rulings/Dissenting Opinion-One Third Rule.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "FLORENCE MACHANI - APPLICATION NO. 2 OF 2015.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Decisions - SC/FLORENCE MACHANI- APPLICATION NO. 2 OF 2015.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "GAUKO Matter.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Court Decisions/GAUKO Matter.pdf",
                    JudgeId = 1
                },
                new Opinion
                {
                    Title = "Gladys Wanjiru Munyi v Diana Wanjiru Munyi.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Court Decisions/Gladys Wanjiru Munyi v Diana Wanjiru Munyi.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "icj v ag-CA 1 0f 2012.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/files/Rulings/icj v ag-CA 1 0f 2012.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Jasbir Petition 4 of 2012 Final Ruling.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/files/Supreme Court/Jasbir Petition 4 of 2012 Final Ruling.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "JMVB2 Judgment with dissent.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Court Decisions/JMVB2 Judgment with dissent.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "JMVB2 JUDGMENT.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Court Decisions/JMVB2 JUDGMENT.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Judgement - IEBC and New Vision.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Court Decisions/Judgement - IEBC and New Vision.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Judgement - Town Council of Awendo.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Court Decisions/Judgement - Town Council of Awendo.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Judgement Shahbal Petition No. 21 of 2014.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Court Decisions/Judgement Shahbal Petition No. 21 of 2014.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Judgment - Anami Silverse Lisamula v IEBC &7 Others.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/files/Cases/Judgment - Anami Silverse Lisamula v IEBC & 7 Others.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Judgment - Fredrick Otieno Outa v Jared Odoyo Okello &Others.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/files/Cases/Judgment - Fredrick Otieno Outa v Jared Odoyo Okello & Others.pdf",
                    JudgeId = 9
                },
                new Opinion
                {
                    Title = "Judgment - Gatirau Peter Munya v Dickson Mwenda Kithinji &Others.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/files/Cases/Judgment - Gatirau Peter Munya v Dickson Mwenda Kithinji & Others.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Judgment - George Michael Wanjohi vs Stephen Kariuki.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/files/Cases/Judgment - George Michael Wanjohi vs Stephen Kariuki.pdf",
                    JudgeId = 9
                },
                new Opinion
                {
                    Title = "Judgment - Hassan Ali Joho &Another v Suleiman Said Shahbal &2 Others.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/files/Cases/Judgment - Hassan Ali Joho & Another v Suleiman Said Shahbal & 2 Others.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Judgment - Nathif Jama Adan v Abdikhaim Osman Mohamed &Others.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/files/Cases/Judgment - Nathif Jama Adan v Abdikhaim Osman Mohamed & Others.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Judgment - Zachary Okoth Obado v Edward Akoth Oyugi &Others.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/files/Cases/Judgment - Zachary Okoth Obado v Edward Akoth Oyugi & Others.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Lawrence Nduttu &6000 others vs KBL Ruling.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/files/Rulings/Lawrence Nduttu & 6000 others vs KBL Ruling.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Ledama Olekina Judgment.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Court Decisions/Ledama Olekina Judgment.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Majority Decision - One Third Rule.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/files/Rulings/Majority Decision-One Third Rule.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Menginya v KRA.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Court Decisions/Menginya v KRA.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "MOTION NO. 4 OF 2013.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/files/Supreme Court/MOTION NO. 4 OF 2013.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Mumo Matemu-Amicus Application.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Court Decisions/Mumo Matemu-Amicus Application.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "National Bank Ltd v Anaj Warehousing 1 - 12 - 2015.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Decisions - SC/National Bank Ltd v Anaj Warehousing 1-12-2015.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Ngoge v 3 others stay application Rules 5 2 b.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Supreme Court 2017/Ngoge v 3 others stay application Rules 5 2 b.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Njihia - Ruling.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Court Decisions/Njihia - Ruling.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "NLC Advisory Opinion 2 - 12 - 2015.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Decisions - SC/NLC Advisory Opinion 2-12-2015.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "ORDER APPL. NO.16 OF 2015 OF 2ND SEPTEMBER 2015.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Decisions - SC/ORDER APPL. NO.16 OF 2015 OF 2ND SEPTEMBER 2015.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "OUTA - Ruling.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Supreme Court 2017/OUTA - Ruling.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "PETER MUNYA RULING.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/files/Rulings/PETER MUNYA RULING.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Petition 14.2016 Oparanya.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/A - Decisions/Petition 14.2016 Oparanya.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Petition 17.2014 Bichage.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Supreme Court 2017/Petition 17.2014 Bichage.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Petition 5 of 2012 Ruling.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/files/Rulings/Petition 5 of 2012 Ruling.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "PETITION NO 6 OF 2012 - Ruling 5th July, 2012.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/files/Rulings/PETITION NO 6 OF 2012-Ruling 5th July, 2012.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Petition No. 1 of 2013 Final Ruling.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/files/Supreme Court/Petition No. 1 of 2013 Final Ruling.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "PETITION NO. 10 OF 2013 JUDGMENT - Hassan Joho[Final].pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/files/DCJ speeches/PETITION NO. 10 OF 2013 JUDGMENT - Hassan Joho [Final].pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Petition No. 10 of 2014....with concurring judg of Njoki SCJ.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/files/Rulings/Petition No. 10 of 2014....with concurring judg of Njoki SCJ.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Petition No. 12 of 2014 - WETANGULA.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Court Decisions/Petition No. 12 of 2014- WETANGULA.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "PETITION NO. 16 OF 2015 - RULING.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Decisions - SC/PETITION NO. 16 OF 2015 - RULING.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Petition No. 18 of 2014.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Decisions - SC/Petition No. 18 of 2014.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Petition No. 2 of 2013 Ruling.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/files/Supreme Court/Petition No. 2 of 2013 Ruling.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Petition No. 23 of 2014..Nick Salat....ed.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Court Decisions/Petition No. 23 of 2014..Nick Salat....ed.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Petition No. 28 of 2014 Delivered April 16 2015.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Court Decisions/Petition No. 28 of 2014 Delivered April 16 2015.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "PETITION NO. 5 OF 2013...DCJ.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/files/Rulings/PETITION NO. 5 OF 2013...DCJ.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Petition Nos 6 and 7 of 2013 - corrected ruling.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/files/Rulings/Petition Nos 6 and 7 of 2013-corrected ruling.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "PO by Omtatah Ruling - 14.06.2016.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Decisions - SC/PO by Omtatah Ruling - 14.06.2016.pdf",
                    JudgeId = 1
                },
                new Opinion
                {
                    Title = "Republic Vs Karisa Chengo and 2 others.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/A - Decisions/Republic Vs Karisa Chengo and 2 others.pdf",
                    JudgeId = 9
                },
                new Opinion
                {
                    Title = "Ruling - Aviation Case.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Court Decisions/Ruling - Aviation Case.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Ruling - Lemanken Aramat v Harun Meitamei Lempanka & 2 Others[14.05.2014].pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/files/Cases/Ruling - Lemanken Aramat v Harun Meitamei Lempanka & 2 Others [14.05.2014].pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Ruling Application Extension of Time to Appeal - Hassan Nyanje v Khatib Mwashetani &3 Others.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/files/Cases/Ruling Application Extension of Time to Appeal - Hassan Nyanje v Khatib Mwashetani & 3 Others.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Ruling Certification & Leave to File Appeal to SC - Bwana Mohamed Bwana v Silvano Buko Bonga &2 Others.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/files/Cases/Ruling Certification & Leave to File Appeal to SC - Bwana Mohamed Bwana v Silvano Buko Bonga & 2 Others.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Ruling in Charles Karathe Matter App. 1 of 2014 2.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Decisions - SC/Ruling in Charles Karathe Matter App. 1 of 2014 2.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "RULING ON ADVISIORY OPINION NO.2 OF 2014.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/files/Rulings/RULING ON ADVISIORY OPINION NO.2 OF 2014.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "RULING ON APPLICATION NO. 10 OF 2016.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/A - Decisions/RULING ON APPLICATION NO. 10 OF 2016.pdf",
                    JudgeId = firstJudge
                },
                new Opinion
                {
                    Title = "Supreme Court Ruling - TSC and Teachers Unions.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Decisions - SC/Supreme Court Ruling - TSC and Teachers Unions.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Telkom - 1 - Ruling.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Court Decisions/Telkom-1 - Ruling.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Twaha vs Timamy Judgment.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Court Decisions/Twaha vs Timamy Judgment.pdf",
                    JudgeId =firstJudge
                },
                new Opinion
                {
                    Title = "Wavinya - Ruling - Supreme Court.pdf",
                    Url = "http://www.judiciary.go.ke/portal/assets/filemanager_uploads/Court Decisions/Wavinya - Ruling - Supreme Court.pdf",
                    JudgeId =firstJudge
                },
            };

            opinions.ForEach(j => context.Opinions.AddOrUpdate(p => p.Title, j));
            context.SaveChanges();

            var memberships = new List<Membership>
            {
                new Membership
                {
                    Title = "Chairman of the Judiciary Committee on Elections",
                    JudgeId = 9
                },
                new Membership
                {
                    Title = "Chairman of a Tribunal appointed by His Excellency the President of the Republic of Kenya to investigate the conduct of a Judge of the High Court of Kenya",
                    JudgeId = 9
                },
                new Membership
                {
                    Title = "First Lady of Rivers State during her husband's tenure as governor.",
                    JudgeId = 6
                },
                new Membership
                {
                    Title = "Member Election Petition Tribunal, Rivers and Imo States, 1990",
                    JudgeId = 7
                },
                new Membership
                {
                    Title = "Member Election Petition Tribunal, Kwara and Anambra States, 2003 and 2004",
                    JudgeId = 7
                },
                new Membership
                {
                    Title = "Member Election Appeal Tribunal, Edo State, 2005 - 2006",
                    JudgeId = 7
                },
                new Membership
                {
                    Title = "Member Election Appeal Tribunal in Oyo, Ogun and Osun States in 2009",
                    JudgeId = 7
                },
                new Membership
                {
                    Title = "Nigerian Bar Association",
                    JudgeId = 8
                },
                new Membership
                {
                Title = "International Bar Association",
                JudgeId = 8
                },
                new Membership
                {
                    Title = "Nigerian Body of Benchers",
                    JudgeId = 8
                }
            };

            memberships.ForEach(j => context.Memberships.AddOrUpdate(p => p.Title, j));
            context.SaveChanges();
        }
    }
}
