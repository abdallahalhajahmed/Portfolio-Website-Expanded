// import MyPic from '../images/MyPic.jpeg';
// import myPic2 from '../images/MyPic2.jpg';
import myPic from '../images/MyPic.jpeg';

function About() {
    return (
        <section id="about" className="container">
          <div className="d-flex justify-content-center align-items-center">
            <h4 
              className="about-header text-center"
              style={{
                marginTop: "100px",
                marginBottom: "30px",
                fontSize: "20px",
                }}
              >
              ABOUT ME
            </h4>
          </div>
          <div className="d-flex justify-content-center mb-2">
            <img className="about-pic align-middle" src={myPic} alt="Abdallah"></img>
          </div>
          <div className="d-flex justify-content-center">
            <p className="mb-3" style={{fontSize:"30px", color:"gray"}}><b>___</b></p>
          </div>
          <div className="d-flex justify-content-center">
            <h3 className="mb-4 text-center" style={{fontSize:"25px"}}><b>MSc in Software Development, University of Glasgow</b></h3>
          </div>
            <div className="d-flex justify-content-center">
                <p className="about-me text-center" style={{fontSize: "18px", maxWidth:"600px"}}>
                  I am a Java Full-Stack Software Developer with an MSc in Software Development and a strong background in Java Test Automation Engineering. 
                  I am excited at the prospect of getting involved in and learning more about Asset Management, investment management systems, and Fixed Income,
                  <br></br><br></br>
                  I have hands-on experience building diverse projects, including building the PalCafe website in collaboration with a UX writer; building a mobile-based Sales Analytics Sheet application in collaboration with a sales compliance manager; and creating multiple robust and extensible web and API test automation frameworks.

                </p> 
              </div>
        </section>
    );
}

export default About;