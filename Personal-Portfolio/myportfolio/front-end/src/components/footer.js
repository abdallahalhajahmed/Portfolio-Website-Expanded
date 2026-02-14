import { FaLinkedin, FaGithub } from "react-icons/fa6";

function Footer() {
    return (
      <footer>
        <div className="p-8 border-top bg-light rounded-3">
          <p className="d-flex justify-content-between">
            <span>Website by Abdallah Alhajahmed</span>
            <span>© Abdallah Alhajahmed 2025</span>
          </p>
            <a href="https://www.linkedin.com/in/abdallah-alhajahmed-82b44926b/" alt="" target="_blank" title="LinkedIn">
              <FaLinkedin 
              size={36} 
              className="icon p-1 inline-block mr-3 text-left"
              />
            </a>
            <a href="https://github.com/abdallahalhajahmed" alt="" title="GitHub" target="_blank">
              <FaGithub 
              size={36} 
              className="icon p-1 inline-block text-left"
              />
            </a>
          </div>
      </footer>
    );
}
export default Footer;