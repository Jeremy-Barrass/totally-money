# totally-money
Back End Tech Test

My perfomance on this particular test does not, in my opinion, do justice to my general capability.

* Attempt in ASP .NET Core MVC => /totally-money/CustomerPreferences

* Attempt in ASP .NET MVC => /totally-money/CustomerPreferencesCentre

## Initial Approach
I did all the code development on Linux in the MonoDevelop IDE.  In retrospect, I clearly should have stuck to Windows and VS 2017 for the ASP .NET Core project I intended, as getting going would have been a lot quicker.  As it was, I spent quite a bit of time getting my chosen IDE upgraded to where it would support .NET Core, then installing all the relevenat Nuget Packages.  This cost me a significant chunk of development time from the outset.

It also lacked a lot of the scaffolding and templating for the project the a lot of docs and tutorials assumed, so in the end I changed tactics and started over in ASP .NET MVC, which at least MonoDevelop has a project Template for.

This allowed me to get a web application running and produce an input page in the browser.  I did not test drive the project anywhere near as much as I would like with the archtitecture.  Were I to do it again, I would probably have it run as a console appliation that loads the input from a text file, which might simplify the unit testing and general project setup.


## Intended Outcome
In any case, my intention with the test was to have a web applicaiton with an input page and a report page.

The input page would allow multiple entries by loading the form inputs as a partial view inside a <div> tag, with a bit of javascript at the bottom of the page to add additional div tags on a "Add Another" button click, if the user wanted to add more customers.  The "Save" button on the page was intended to submit the whole form to an api, which would save the information as a text file initially, with sufficient decouling in the system to allow for adding a database later if required.  I started with a single entry on the form and would have added multiple entry functionality once I had it saving successfully.

The report page would render the report as per the test spec, loading in the text file via an api call.

As the outcome of my attempt stands, I'm somewhat disappointed in myself and don't feel on this occasion I have produced enough in my code to indicate my intentions for the application, though at least have a reminder to ensure I use the appropriate tools next time.  Nonetheless, I hope this explanation is found sufficient to work with in a future pairing exercise.
