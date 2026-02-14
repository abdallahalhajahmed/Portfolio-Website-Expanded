import myPic2 from '../images/MyPic2.jpg';
import Typewriter from "typewriter-effect";

function Home() {
    return (
        <section className="container" id="home">
            <div className="row">
              <div className="col-12 my-11 col-md-6 text-md-start">
                <img className="home-pic ml-11 img-fluid shadow-lg" src={myPic2} alt="Abdallah" loading="lazy"></img>
              </div>
              <div 
                className="type-writer py-5 fs-2 col-12 col-md-6 text-center text-md-center" 
                > 
                  <p className="mb-5 fs-2 fw-bold">Abdallah's Portfolio Website.</p>
                  <Typewriter
                    options={{
                    strings: [
                      "Sparta Global Consultant",
                      "Full-Stack Java Developer", 
                      "Java Test Automation Engineer",
                      "MSc, Software Development ",
                    ],
                    autoStart: true,
                    loop: true,
                    delay: 20,
                    deleteSpeed: 20,
                    pauseFor: 2500,
                    cursor: "▏"
                  }}
                  />
              </div>
            </div>
        </section>
    );
}
export default Home;