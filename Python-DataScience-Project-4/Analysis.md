## The Behavioral Risk Factor Surveillance System (BRFSS)


_The Behavioral Risk Factor Surveillance System (BRFSS)_ is the nation’s premier system of health-related telephone surveys that collect state data about U.S. residents regarding their health-related risk behaviors, chronic health conditions, and use of preventive services. Established in 1984 with 15 states, BRFSS now collects data in all 50 states as well as the District of Columbia and three U.S. territories. BRFSS completes more than 400,000 adult interviews each year, making it the largest continuously conducted health survey system in the world. 

(Courtsey: [CDC](https://www.cdc.gov/brfss/index.html))

![cover](./Images/cover1.png)

_This project focused on the 2015 data and a small subset of the factors questioned about. As far as diseases, included is: cancer, high cholesterol, diabetes, heart disease, and high blood pressure. In order to see the impact of both positive and negative  behaviors on health, two of each are included. In the beneficial behavior section is fruit and vegetable intake per day and minutes  of physical activity per day and in the negative section is alcohol consumption per day  and smoking rate per day. As far as  demographics body mass index (BMI), education level, and state of residence and age are included._


### Data Exploration and Cleaning

_Original Raw Data Preview_

![Original_Data_Preview](Images/data_exploration/Original_Data_Preview.png)

_Original MetaData_

![metadata_original_data](Images/data_exploration/metadata_original_data.png)

_Reduced Raw Data Preview_

![reduced_data](Images/data_exploration/reduced_data.png)

_Final Data_

![final_data](Images/data_exploration/final_data.png)

_Final MetaData_

![final_metadata](Images/data_exploration/final_metadata.png)


_Preview of Descriptive statistical Info_

![data_describe](Images/data_exploration/data_describe.png)

_Pairwise Correlation of Numerical Data_

![corr_table](Images/data_exploration/corr_table.png)


_First, we analyzed the relation between our four behaviors and three demographic levels._ 

### Data Analysis

#### Weight Vs Positive Habits

* Questions :
1) Are men or women more physically active? 
2) Do men or women have healthier habits?

* Weight in Lbs Vs Fruits and Vegetables/Day

![fruit_veggie_wt](Images/data_analysis/fruit_veggie_wt.png)


_Analysis/Trend_

_In this part of our data analysis, we looked at the pattern between weight and fruit + vegetable consumption (combined) by considering participants genders.
1) The scatter plot showed that the higher weight people eat less fruit or vegetable._



* Weight in Lbs Vs Minutes of Physical Activity/Day

![physical_wt](Images/data_analysis/physical_wt.png)

_Analysis/Trend_

_We can see that as more minutes spent on physical activity, no cases of weight increase is seen. But most of the people perform physical activity in 0 to 500 minutes. No we are not sure what kind of physical activities people are referring to as there are good amout of people in the range of 500 to 1000 minutes also. Some occupations also demand physically strenuous work to be done. On the whole women tend to perfome less physical activites and also 80 to 150 lbs whereas men who perform low physical activity seems weight higher reaching up to 600 lbs._


#### Weight Vs Negative Habits

* Question : 
1) Is there an identifiable trend between weight and smoking? drinking?

* Weight in lbs Vs Alcohol consumption per day

![alcohol_wt](Images/data_analysis/alcohol_wt.png)

_Analysis/Trend_

_In this graph, we observed a negative correlation between weight and alcohol consumption.  This might not be accurate  (many studies shows that alcohol cause weight gain ) due to various other parameters. This part needs further investigation._

* Weight Vs Smoking rate per day

![smoking_wt](Images/data_analysis/smoking_wt.png)

_Trend/Analysis_

_There is no specific trend seen on weight with smoking and mostly weight range between 100 and 300 for people smoke some days or every day. Also women smoke less than men_

#### Education Vs Habits

* Questions
    1) Is there an identifiable trend between education level and smoking? drinking?
    


![education_habits](Images/data_analysis/education_habits.png)


_Trend/Analysis_

_In this segment of our project, we crafted a line chart of education level and habits. Education level for this study is comprised of six categories: No school, elementary, middle, junior high, college 3 yrs, and college 4yrs. The habits we were interested in analyzing were Fruit consumption per day, Vegetable consumption per day,  Physical activities per day, alcohol consumption per day, and % of smoking._

_Line chart showed that:_
- _Fruit consumption is correlated with education level except for the segment between no school and elementary._
- _Vegetable consumption goes down from no school to primary and stays constant for other levels of education.  This is an interesting data point._
- _Physical activity goes up from no school to elementary and almost stays the same as vegetable data. Except for a minor declination from college 3 yrs to college 4yrs._
- Alcohol consumption shows the same from no school to high school. However, it linearly goes down from high school to college 4 yrs.
- _Smoking patterns are slightly different from the rest. It is the same for no school and elementary; however, the smoking rate goes up from the middle to high school education. Then it starts going down from high school to all the way college 4 yrs._
- _There is a positive correlation between alcohol consumption and smoking rate for almost all educational levels._


#### State of Residence Vs Habits and Health Risks

* Questions:
    1) Is drinking contributing to any of the diseases and  which one?
    2) What trend can be seen with various habits and diseases?
    3) Is alcohol more dangerous than smoking according to the survey results?
    4) States with highest adult smoking ?
    5) Which state top high alcohol consumption?
    6) Any trend seen in diseases reported based on the states/location where they live?


![states_habits_diseases](Images/data_analysis/states_habits_diseases.png)

_In this graph, we were interested in seeing the pattern between total diseases and behaviors (fruit consumption, vegetable consumption, physical activities, smoking, and alcohol consumption) for ten states._
- _The line chart showed that the more people eat vegetable and fruit the less diseases they confront._
- _Surprisingly, the line chart does not show a clear pattern between smoking rate and total diseases and physical activities and total diseases as well.  In some segments of the graph, there is a positive correlation; on the other hand, in some areas it shows the opposite. It is maybe due to the sample size._

- _There is also an inconsistency between total diseases and weight. Some areas of the graph show a positive trend between weight and  the total diseases; however, in some areas there is positive which we were not expecting to be that way. It is maybe due to the sample size._


_Trend/Analysis_

* Top Fruits and Vegetables consumption

![Fruit_aconsumption](Images/data_analysis/Fruit_aconsumption.png)



![Vegatable_consumption](Images/data_analysis/Vegatable_consumption.png)


_Analysis/Trend_

_Fruits Consumption Per Day (Top 10 States)_

_We found average fruits consumption for all states along with the territory. The bar chart shows the states that consume most fruits are as follows:_
DC, ME, MA, NY, CT, NH , VT , MI , RI , OR

_We found vegetable consumption for all states along with the territory. The bar chart shows the states that consume the most fruits are as follows:_
VT, OR, AK , TX , CA , DC , GA , ME , GU , NV

* Top States by Smoking rate per day

![Smoking_Per_States](Images/data_analysis/Smoking_Per_States.png)

_Analysis/Trend_

_In terms of the data itself, this chart shows which states have the most participants in the actual survey. According to this data, northern states appear to have a greater number of partipants in general._

_Analysis/Trend_

* Top States by Alcohol consumption per day

![State_alcohol](Images/data_analysis/State_alcohol.png)

_Analysis/Trend_

_Puerto Rico and Guam have the highest alcohol consumption per day out of all of the states and territories listed. Does this indicate that the residents of the U.S. territories consume more alcohol on average than the residents of the states? Further, both Hawaii and Alaska are within the top ten. Does this further the argument that the areas seperated from the mainland consume more alcohol?_

* States by Physical Activities per day

![Pyhsical_activity](Images/data_analysis/Pyhsical_activity.png)

_Analysis/Trend_

_Wyoming, Nevada and Oregan appear to be the most active states. These are all relatively Nortern states._

#### Demographic factors Vs five Health Risk Indicators.

* Questions:
1) Is there any trend we see with BMI with diseases we develop?
2) Any trend on health risk indicators based on education level of the people?


* Body Mass Index (BMI) and Health Risk Indicators

![bmi_diseases](Images/data_analysis/bmi_diseases.png)


_Analysis/Trend_

_In this graph we are analysing Body Mass Index against various reported Health Risk Indicators like Cancer, High Blood Pressure and High Cholestrol._
_It appears that occurrences of cancer peak within the overweight BMI range but lessen again within the obese range. Does this indicate a lack of relation between cancer and weight issues? Diabetes and Heart Disease seems to be of lower percentage (<5 %) for Diabetes and Heart Disease and <30 % for High Blood Pressure and High Cholestrol until BMI is of Normal Weight and starts to rise high towards Overweight and Obese levels._
_So overall four diseases (high blood pressure, high cholesterol, heart disease, and diabetes) and increased BMI appear to be directly correlated. And so it's worth to follow positive habits to take control of weight and be in the Normal Weight category._ 

* Education Level and Health Risk Indicators

![education_diseases](Images/data_analysis/education_diseases.png)

_Analysis/Trend_

_Instances of diabetes peak dramatically for those who were only educated at a high school level. We already saw that diabetes is related to a higher BMI and that more educated people exhibit healthier habits. Is that what we're seeing here. Alternatively, is this number high because diabetes can impact the youth as well? Are we seeing the number of people unable to continue education due to illness? Heart disease, high cholesterol, and high blood pressure levels are all highest for people who only completed elementary or junior high. This matches the diabetes data as well. This indicates that those who have some level of education but never completed high school are most likely to suffer from these diseases. Alternatively, cancer appears to not follow this trend. It increases as people become more educated which could also be that._
_In nutshell, education seems to drive awareness, and follow positive habits eventually lowering the health risks_


* State of Residence and Health Risk Indicators

![top_healthy](Images/data_analysis/top_healthy_10.png)

_Analysis/Trend_

_Eight out of the ten top healthy states are connected to large bodies of water. Percentage of diseases reported based on survey data shows that lowest percentage reported is 17.86 by territory Guam followed by Vermont at 18.41%._

![least_healthy](Images/data_analysis/least_healthy_10.png)

_Analysis/Trend_

_Highest percentage is reported by Arizona at 25.98 followed by territory Puerto Rico (25.97), Maryland (25.47), LA (25.26) and Missouri (24.96) percentages. So seems like mostly southern states have reported more diseases that central and northern states. We can see that majority of the states that have reported highest diseases fall into the category of top 10 poorest states in US. ( Poorest states in US Louisiana, Mississippi, New Mexico, West Virginia, Alabama, Arkansas, Kentucky, South Carolina, Arizona, and Georgia._

_This indicates that more investment in health sector and educating the people in these states could be done._

####  Extra Demographic Analysis:

* Age Vs Health Risk Indicators

![age_disease](Images/data_analysis/age_disease.png)

_Based on the survey data, Heart Disease looks to be the most prevalent disease among all age groups calculated percent wise. 65-69 age groups looks to be one suffering maximum from all diseases 17.5 to 20%] of people in the age groups affected with Cancer and Heart Disease being the top diseases. QTNs? 1)Is it because the median of living retiree left work is at 62 years old, and the most common age to retire was 62 years old. 2)Also once people, retire, insurance coverage might cease to exist if not enough retirement savings. 3)It is also alarming to notice the incidence of Blood Pressure as the highest disease among 18-24 age groups though they represent only around 0.5% of the total respondents. This could be due to high level of stress, anxiety or issues with unemployment? 4) Every age groups, we can almost consistently see High Blood cholesterol as the number 1 health risk factor. IS this due to lack of healthy food habits, and lack of physical activities?_

* Gender Vs Health Risk Indicators

* Questions :
    1. What trend can be seen between age groups and type of diseases?
    2. Any trend can be seen between gender type and type of diseases?
    
![gender_disease](Images/data_analysis/gender_disease.png)

_Survey data shows that men outnumber women in all health risk indicatory with Heart disease being the top most one with 73.77%. Women with Cancer as the top most health risk indicator with 51.66%. But as per https.Cancer.gov, https://www.cancer.gov/about-cancer/understanding/statistics 1.8% per year among men from 2006 to 2015 1.4% per year among women from 2006 to 2015 -It could be because, the sample data we have collected not actually representing the actual population._

_Qtns: 1) Is it because many of contributing factors of Heart disease are Drinking, Smoking Obesity which might be common issues among Men than Women? 2) The survey data shows that Women mostly affected by Cancer though_

_On average, Americans can now expect to live 78.6 years, a statistically significant drop of 0.1 year, according to a report on 2016 data published Thursday by the National Center for Health Statistics. Women can now expect to live a full five years longer than men: 81.1 years vs. 76.1 years._ [link](https://www.smithsonianmag.com/smart-news/us-life-expectancy-drops-third-year-row-reflecting-rising-drug-overdose-suicide-rates-180970942/)


#### Country wise status on 5 Health Risk indicators.

![DieseasesPie](Images/data_analysis/DieseasesPie.png)

_Analysis/Trend_

_Based on the survey data, Cholestrol is the most prevalent health risk factor (38.3%) in the country follwed by High Blood Pressure (37.5%), Cancer (9.6%), Diabetes (9.1%) and Heart Disease (5.5%)._

_Below are the latest percentages we have obtained from CDC website as it's prevalent now._

* CDC Facts


[Cholestrol - 71 million American adults (33.5%)](https://www.cdc.gov/dhdsp/data_statistics/fact_sheets/fs_cholesterol.htm)

[Blood Pressure - 75 million American adults (32%)](https://www.cdc.gov/dhdsp/data_statistics/fact_sheets/fs_bloodpressure.htm)

[Cancer -23.2 million American Adults (9.4%)](https://www.cdc.gov/nchs/fastats/cancer.htm)

[Heart Disease - 28.2 million Americans (11.5%)](https://www.cdc.gov/nchs/fastats/heart-disease.htm)

[Diabetes - 30.3 million Americans Adults (9.4%)](https://www.cdc.gov/media/releases/2017/p0718-diabetes-report.html)
